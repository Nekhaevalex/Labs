//
//  main.c
//  CalcMathLab3
//
//  Created by Alexander Nekhaev on 03.12.2018.
//  Copyright © 2018 Alexander Nekhaev. All rights reserved.
//

#include <stdio.h>
#include <math.h>
#include <stdlib.h>
#include <stdbool.h>
#define FTYPE long double

#define TwoStepRK 3
#define ThreeStepRK 4
#define FourStepRK 5

FTYPE EulerModifiedMethod[3][3] = {
	{0,0,0},
	{0.5,0.5,0},
	{0,0,1}
};

FTYPE EulerRecountMethod[3][3] = {
	{0,0,0},
	{1,1,0},
	{0,0.5,0.5}
};

FTYPE HeunMethod[4][4] = {
	{0,0,0,0},
	{1/3, 1/3, 0, 0},
	{2/3, 0, 2/3, 0},
	{0, 1/4, 0, 3/4}
};

FTYPE RK32[4][4] = {
	{0,0,0,0},
	{2/3,2/3,0,0},
	{2/3,-1/3,1,0},
	{0,1/4,2/4,1/4}
};

FTYPE RK33[4][4] = {
	{0,0,0,0},
	{1/2,1/2,0,0},
	{1,-1,2,0},
	{0,1/6,4/6,1/6}
};

FTYPE RK4Classic[5][5] = {
	{0, 0, 0, 0, 0},
	{0.5, 0.5, 0, 0, 0},
	{0.5, 0, 0.5, 0, 0},
	{1, 0, 0, 1, 0},
	{0, 1.0/6.0, 2.0/6.0, 2.0/6.0, 1.0/6.0}
};

FTYPE dyx(FTYPE x, FTYPE y) {
	return ((y-x*y*y)/x);
}

FTYPE* evaluateF(int funcNum, FTYPE xn, FTYPE yn, FTYPE** MethodMatrix, FTYPE h) {
	FTYPE* f = malloc(sizeof(FTYPE)*4);
	for (int i = 0; i<4; i++) {
		f[i] = 0;
	}
	f[0] = dyx(xn,yn);
	for (int i = 1; i<funcNum-1; i++) {
		FTYPE x = xn+MethodMatrix[i][0]*h;
		FTYPE y = yn;
		for (int j = 1; j<i+2; j++) {
			FTYPE M = MethodMatrix[i][j];
			y += MethodMatrix[i][j]*f[j-1]*h;
		}
		FTYPE fi = dyx(x,y);
		f[i] = dyx(x,y);
	}
	return f;
}

FTYPE evaluateY(FTYPE yn, FTYPE** MethodMatrix, FTYPE* functions, int length, FTYPE h) {
	FTYPE ynp1 = yn;
	for (int i = 1; i<length; i++) {
		FTYPE a = MethodMatrix[length-1][i];
		ynp1 += functions[i-1]*MethodMatrix[length-1][i]*h;
	}
	return ynp1;
}

FTYPE X0 = 1.0;
FTYPE Y0 = 2.0;
FTYPE borders[2] = {1.0, 3.0};
FTYPE epsilon = 1E-4;

FTYPE evalGridStepH(int steps) {
	return (borders[1]-borders[0])/steps;
}

bool checkIfErrorAcceptable(FTYPE delta, int method) {
	FTYPE val = (fabsl(delta))/(powl(2.0, method)-1);
	return val <= epsilon ? false : true;
}


int main(int argc, const char * argv[]) {
	FTYPE* f = NULL;
	FTYPE* fProxy = NULL;
	FTYPE** method = malloc(sizeof(FTYPE*)*5);
	for (int i = 0; i<5; i++) {
		method[i] = malloc(sizeof(FTYPE)*5);
	}
	FTYPE calcPoints[11];
	FTYPE valuesInPoints[11];
	FTYPE valuesInPointsProxy[11];
	FTYPE deltas[11];
	for (int i = 0; i<11; i++) {
		calcPoints[i] = borders[0]+((borders[1]-borders[0])/10)*i;
	}
	valuesInPoints[0] = Y0;
	valuesInPointsProxy[0] = Y0;
	for (int i = 0; i<5; i++) {
		for (int j = 0; j<5; j++) {
			method[i][j] = RK4Classic[i][j];
		}
	}
	int steps = 10;
	FTYPE maxDelta;
	FTYPE h = 0.0;
	FTYPE x = X0;
	FTYPE xProxy = X0;
	FTYPE value = Y0;
	FTYPE valueProxy = Y0;
	do {
		x = X0;
		xProxy = X0;
		value = Y0;
		valueProxy = Y0;
		for (int i = 0; i<=steps; i++) {
			h = evalGridStepH(steps);
			x = h*i+X0;
			xProxy = 2*h*i+X0;
			for (int j = 0; j<11; j++) {
				if (x == calcPoints[j]) {
					valuesInPoints[j] = value;
				}
				if (xProxy == calcPoints[j]) {
					valuesInPointsProxy[j] = valueProxy;
					break;
				}
			}
			f = evaluateF(FourStepRK, x, value, method, h);
			fProxy = evaluateF(FourStepRK, xProxy, valueProxy, method, 2*h);
			value = evaluateY(value, method, f, FourStepRK, h);
			valueProxy = evaluateY(valueProxy, method, fProxy, FourStepRK, 2*h);
		}
		free(f);
		free(fProxy);
		for (int i = 0; i<11; i++) {
			deltas[i] = fabsl(valuesInPointsProxy[i]-valuesInPoints[i]);
		}
		maxDelta = deltas[0];
		for (int i = 1; i<11; i++) {
			if (maxDelta < deltas[i]) {
				maxDelta = deltas[i];
			}
		}
		steps = steps*2;
	} while (checkIfErrorAcceptable(maxDelta, FourStepRK));
	printf("Calculated with %d steps\nAccuracy: %Lf\nh=%Lf\n", steps/2, epsilon, h);
	for (int i = 0; i<11; i++) {
		printf("%d) x=%Lf\n\ty(h)=%Lf\n\ty(2h)=%Lf\n\t--------------\n\ty(2h)-y(h)=%Lf\n\n", i+1, calcPoints[i], valuesInPoints[i], valuesInPointsProxy[i], valuesInPointsProxy[i]-valuesInPoints[i]);
	}
	return 0;
}
