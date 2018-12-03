//
//  main.c
//  CalcMathLab2
//
//  Created by Alexander Nekhaev on 30.10.2018.
//  Copyright © 2018 Alexander Nekhaev. All rights reserved.
//

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <math.h>
#define FTYPE long double

FTYPE sourceData[7][2] = {{0.17453, 0.000012}, {0.52360, 0.00026}, {0.87267, 0.0025}, {1.22173,
	0.01815}, {1.5708, 0.09763}, {1.91986, 0.40593}, {2.26893,
		1.38035}};
int length = 7;

//FTYPE sourceData[6][2] = {{0.17453, 0.00162}, {0.5236, 0.00252}, {0.87267, 0.00498}, {1.22173,
//	0.0129}, {1.5708, 0.03964}, {1.91986, 0.1207}};
//int length = 6;

FTYPE getB(int argc, int* argv, FTYPE source[7][2]) {
	if (argc == 1) {
		return source[argv[0]][1];
	} else {
		int xs1[7];
		int xs2[7];
		int lensub = argc-1;
		for (int i = 0; i<lensub; i++) {
			xs1[i] = argv[i];
		}
		for (int i = 1; i<argc; i++) {
			xs2[i-1] = argv[i];
		}
		FTYPE fa = getB(lensub, xs2, source);
		FTYPE fb = getB(lensub, xs1, source);
		
		return (fa-fb)/(source[argc-1][0]-source[0][0]);
	}
}

FTYPE evaluate(FTYPE* function, FTYPE x) {
	FTYPE result = 0;
	for (int i = 0; i<length; i++) {
		result += function[i] * powl(x, (FTYPE)i);
	}
	return result;
}

FTYPE* D(FTYPE* function) {
	FTYPE* result = malloc(sizeof(FTYPE)*6);
	for (int i = 1; i<7; i++) {
		result[i-1] = function[i]*(i);
	}
	return result;
}

FTYPE* calculateSplineCoefs(FTYPE* function, FTYPE points[7][2], int i) {
	FTYPE xi = points[i][0];
	FTYPE xi1 = points[i+1][0];
	
	FTYPE* pnd = D(function);
	
	FTYPE fi = evaluate(function, xi);
	FTYPE fi1 = evaluate(function, xi1);
	FTYPE pdi = evaluate(pnd, xi);
	FTYPE pdi1 = evaluate(pnd, xi1);
	FTYPE dfi = fi1-fi;
	FTYPE H = xi1-xi;
	FTYPE dh3 = powl(xi1-xi, 3.0);
	
	FTYPE a3 = ((pdi1 * H - 2.0 * dfi + pdi * H) / dh3);
	FTYPE a2 = ((-pdi1 * H * (xi1 + 2.0 * xi) + 3.0 * dfi * (xi1 + xi) - pdi * H * (xi + 2.0 * xi1)) / dh3);
	FTYPE a1 = ((pdi1 * xi * (xi + 2.0 * xi1) * H - 6.0 * dfi * xi * xi1 + pdi * xi1 * (xi1 + 2.0 * xi) * H) / dh3);
	FTYPE a0 = ((-pdi1 * xi * xi * xi1 * H + fi1 * xi * xi * (3.0 * xi1 - xi) + fi * xi1 * xi1 * (xi1 - 3.0 * xi) - pdi * xi * xi1 * xi1 * H) / dh3);
	
	FTYPE* res = malloc(4*sizeof(FTYPE));
	res[0] = a0;
	res[1] = a1;
	res[2] = a2;
	res[3] = a3;
	return res;
}

FTYPE** getAllSplineCoefs(FTYPE* function, FTYPE points[7][2]) {
	FTYPE** coefs = malloc(sizeof(FTYPE*)*length);
	for (int i = 0; i<length; i++) {
		coefs[i] = malloc(sizeof(FTYPE)*4);
	}
	for (int i = 0; i<length; i++) {
		for (int j = 0; j<4; j++) {
			coefs[i][j] = 0.0;
		}
	}
	FTYPE* line = NULL;
	for (int i = 0; i<length-1; i++) {
		line = calculateSplineCoefs(function, points, i);
		for (int j = 0; j<4; j++) {
			coefs[i][j] = line[j];
		}
	}
	return coefs;
}

FTYPE calculateInPoint (FTYPE** splineCoefs, FTYPE points[7][2], FTYPE x) {
	FTYPE result = 0;
	bool inBounds = false;
	for (int i = 0; i<length-1; i++) {
		if ((x >= sourceData[i][0]) && (x <= sourceData[i+1][0])) {
			inBounds = true;
			for (int j = 0; j<4; j++) {
				result += splineCoefs[i][j] * powl(x, j);
			}
		}
	}
	if (inBounds) {
		return result;
	} else {
		printf("Error: Not in spline bounds\n");
		return 0;
	}
}

static void makeCache(long double (*cache)[2]) {
	for (int i = 0; i<length/2+1; i++) {
		cache[i][0] = sourceData[length-1-i][0];
		cache[length-1-i][0] = sourceData[i][0];
		cache[i][1] = sourceData[length-1-i][1];
		cache[length-1-i][1] = sourceData[i][1];
	}
}

static void primaryInterpolation(long double (*cache)[2], long double *stringOfCoeffs) {
	for (int i = 0; i<length; i++) {
		int xs[7];
		int len = i+1;
		for (int j = 0; j<=i; j++) {
			xs[j] = j;
		}
		printf("%Lf",getB(len, xs, cache));
		stringOfCoeffs[i] = getB(len, xs, cache);
		for (int j = 0; j<i; j++) {
			printf("(x-%Lf)", cache[j][0]);
		}
		if (i<length-1) {
			printf("+");
		}
	}
}

static void simplifyInterpolation(long double (*cache)[2], long double *simpleFormOfPolynom, long double *stringOfCoeffs) {
	FTYPE brackets[7][2];
	for (int i = 0; i<6; i++) {
		brackets[i][0]=(-1)*cache[i][0];
		brackets[i][1]=1.0;
	}
	FTYPE last[7];
	for (int i = 0; i<7; i++) {
		last[i] = 0.0;
	}
	FTYPE lastW[7];
	for (int i = 0; i<7; i++) {
		lastW[i] = last[i];
	}
	last[0] = 1;
	for (int i = 0; i<length; i++) {
		for (int j = 0; j<length; j++) {
			simpleFormOfPolynom[j] += stringOfCoeffs[i]*last[j];
		}
		for (int br = i; br<=i; br++) {
			for (int k = 0; k<2; k++) {
				for (int cf = 0; cf<length; cf++) {
					lastW[cf+k] += last[cf]*brackets[br][k];
				}
			}
			for (int j = 0; j<length; j++) {
				last[j] = lastW[j];
				lastW[j] = 0.0;
			}
		}
	}
	for (int i = 0; i<length; i++) {
		if (i == 0) {
			printf("%Lf", simpleFormOfPolynom[i]);
		} else {
			printf("%Lf*x^%d", simpleFormOfPolynom[i], i);
		}
		if ((i<length-1) && (simpleFormOfPolynom[i+1]>0)) {
			printf("+");
		}
	}
}

int main(int argc, const char * argv[]) {
	FTYPE cache[7][2];
	FTYPE simpleFormOfPolynom[7];
	for (int i = 0; i<7; i++) {
		simpleFormOfPolynom[i] = 0.0;
	}
	FTYPE stringOfCoeffs[7];
	for (int i = 0; i<7; i++) {
		stringOfCoeffs[i] = 0.0;
	}
	makeCache(cache);
	printf("Input data:\n");
	for (int i = 0; i<length; i++) {
		printf("{%Lf, %Lf}\n",cache[i][0],cache[i][1]);
	}
	printf("\nInterpolation:\nP_N(x)=");
	primaryInterpolation(cache, stringOfCoeffs);
	printf("\n\nSimplified:\n");
	simplifyInterpolation(cache, simpleFormOfPolynom, stringOfCoeffs);
	printf("\n");
	printf("\nSpline coefs:\n");
	for (int i = 0; i<length; i++) {
		cache[i][0] = sourceData[i][0];
		cache[i][1] = sourceData[i][1];
	}
	FTYPE** coefs = getAllSplineCoefs(simpleFormOfPolynom, cache);
	for (int i = 0; i<length-1; i++) {
		printf("{");
		for (int j = 0; j<4; j++) {
			if (j < 3) {
				printf("%Lf,", coefs[i][j]);
			} else {
				printf("%Lf", coefs[i][j]);
			}
		}
		printf("}");
		if (i<length-2) {
			printf(",\n");
		}
	}
	printf("\nInput x point: ");
	FTYPE x;
	scanf("%Lf", &x);
	FTYPE result = calculateInPoint(coefs, sourceData, x);
	printf("S(%Lf)=%Lf\n", x, result);
	return 0;
}
