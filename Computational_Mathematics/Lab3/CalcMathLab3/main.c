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

#define EULER_MODIFIED_METHOD 1
#define EULER_RECOUNT_METHOD 2
#define HEUN_METHOD 3
#define RK32_METHOD 4
#define RK33_METHOD 5
#define RK4_CLASSIC_METHOD 6

//Set up here!!!!

#define DYX (-2 * powl(x, 2) - 3 * x*y + powl(y, 2)) / (x*(x - y))
#define METHOD EULER_MODIFIED_METHOD
#define X0_VALUE 1.0
#define Y0_VALUE 1+sqrtl(2)
#define BORDER_LEFT 1.0
#define BORDER_RIGHT 2.9
#define EPSILON 1E-4

//Set up ends here.

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
	{1.0 / 3.0, 1.0 / 3.0, 0, 0},
	{2.0 / 3.0, 0, 2.0 / 3.0, 0},
	{0, 1.0 / 4.0, 0, 3.0 / 4.0}
};

FTYPE RK32[4][4] = {
	{0,0,0,0},
	{2.0 / 3.0,2.0 / 3.0,0,0},
	{2.0 / 3.0,-1.0 / 3.0,1,0},
	{0,1 / 4,2 / 4,1 / 4}
};

FTYPE RK33[4][4] = {
	{0,0,0,0},
	{1.0 / 2.0,1.0 / 2.0,0,0},
	{1.0,-1.0,2.0,0},
	{0,1.0 / 6.0,4.0 / 6.0,1.0 / 6.0}
};

FTYPE RK4Classic[5][5] = {
	{0, 0, 0, 0, 0},
	{0.5, 0.5, 0, 0, 0},
	{0.5, 0, 0.5, 0, 0},
	{1, 0, 0, 1, 0},
	{0, 1.0 / 6.0, 2.0 / 6.0, 2.0 / 6.0, 1.0 / 6.0}
};

FTYPE dyx(FTYPE x, FTYPE y) {
	return DYX;
}

FTYPE* evaluateF(int funcNum, FTYPE xn, FTYPE yn, FTYPE** MethodMatrix, FTYPE h) {
	FTYPE* f = (FTYPE*)malloc(sizeof(FTYPE) * 4);
	for (int i = 0; i < 4; i++) {
		f[i] = 0;
	}
	f[0] = dyx(xn, yn);
	for (int i = 1; i < funcNum - 1; i++) {
		FTYPE x = xn + MethodMatrix[i][0] * h;
		FTYPE y = yn;
		for (int j = 1; j < i + 2; j++) {
			FTYPE M = MethodMatrix[i][j];
			y += MethodMatrix[i][j] * f[j - 1] * h;
		}
		FTYPE fi = dyx(x, y);
		f[i] = dyx(x, y);
	}
	return f;
}

FTYPE evaluateY(FTYPE yn, FTYPE** MethodMatrix, FTYPE* functions, int length, FTYPE h) {
	FTYPE ynp1 = yn;
	for (int i = 1; i < length; i++) {
		FTYPE a = MethodMatrix[length - 1][i];
		ynp1 += functions[i - 1] * MethodMatrix[length - 1][i] * h;
	}
	return ynp1;
}

FTYPE X0 = X0_VALUE;
FTYPE Y0 = Y0_VALUE;
FTYPE borders[2] = { BORDER_LEFT, BORDER_RIGHT };
FTYPE epsilon = EPSILON;

FTYPE evalGridStepH(int steps) {
	return (borders[1] - borders[0]) / steps;
}

bool checkIfErrorAcceptable(FTYPE delta, int method) {
	FTYPE val = (fabsl(delta)) / (powl(2.0, method) - 1);
	return val <= epsilon ? false : true;
}


int main(int argc, const char * argv[]) {
	FTYPE* f = NULL;
	FTYPE* fProxy = NULL;
	FTYPE** method = (FTYPE**)malloc(sizeof(FTYPE*) * 5);
	for (int i = 0; i < 5; i++) {
		method[i] = (FTYPE*)malloc(sizeof(FTYPE) * 5);
	}
	int methodSelector = METHOD;
	FTYPE calcPoints[11];
	FTYPE valuesInPoints[11];
	FTYPE valuesInPointsProxy[11];
	FTYPE deltas[11];
	for (int i = 0; i < 11; i++) {
		calcPoints[i] = borders[0] + ((borders[1] - borders[0]) / 10)*i;
	}
	valuesInPoints[0] = Y0;
	valuesInPointsProxy[0] = Y0;
	int stepM = 0;
	if ((methodSelector == EULER_MODIFIED_METHOD) || (methodSelector == EULER_RECOUNT_METHOD)) {
		stepM = TwoStepRK;
	}
	else if (((methodSelector == HEUN_METHOD) || (methodSelector == RK32_METHOD)) || (methodSelector == RK33_METHOD)) {
		stepM = ThreeStepRK;
	}
	else if (methodSelector == RK4_CLASSIC_METHOD) {
		stepM = FourStepRK;
	}
	else
	{
		return -1;
	}
	for (int i = 0; i < 5; i++) {
		for (int j = 0; j < 5; j++) {
			if (methodSelector == EULER_MODIFIED_METHOD) {
				method[i][j] = EulerModifiedMethod[i][j];
			}
			else if (methodSelector == EULER_RECOUNT_METHOD) {
				method[i][j] = EulerRecountMethod[i][j];
			}
			else if (methodSelector == HEUN_METHOD) {
				method[i][j] = HeunMethod[i][j];
			}
			else if (methodSelector == RK32_METHOD) {
				method[i][j] = RK32[i][j];
			}
			else if (methodSelector == RK33_METHOD) {
				method[i][j] = RK33[i][j];
			}
			else if (methodSelector == RK4_CLASSIC_METHOD) {
				method[i][j] = RK4Classic[i][j];
			}
			else
			{
				return -1;
			}
		}
	}
	int steps = 5;
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
		for (int i = 0; i <= steps; i++) {
			h = evalGridStepH(steps);
			x = h * i + X0;
			xProxy = 2 * h*i + X0;
			for (int j = 0; j < 11; j++) {
				if (x == calcPoints[j]) {
					valuesInPoints[j] = value;
				}
				if (xProxy == calcPoints[j]) {
					valuesInPointsProxy[j] = valueProxy;
					break;
				}
			}
			f = evaluateF(stepM, x, value, method, h);
			fProxy = evaluateF(stepM, xProxy, valueProxy, method, 2 * h);
			value = evaluateY(value, method, f, stepM, h);
			valueProxy = evaluateY(valueProxy, method, fProxy, stepM, 2 * h);
		}
		free(f);
		free(fProxy);
		for (int i = 0; i < 11; i++) {
			deltas[i] = fabsl(valuesInPointsProxy[i] - valuesInPoints[i]);
		}
		maxDelta = deltas[0];
		for (int i = 1; i < 11; i++) {
			if (maxDelta < deltas[i]) {
				maxDelta = deltas[i];
			}
		}
		steps = steps * 2;
	} while (checkIfErrorAcceptable(maxDelta, stepM));
	printf("Calculated with %d steps\nAccuracy: %Lf\nh=%Lf\nDiff=%Le\n\n", steps / 2, epsilon, h, maxDelta);
	for (int i = 0; i < 11; i++) {
		printf("%d) x=%Lf\n\ty(h)=%Lf\n\ty(2h)=%Lf\n\t--------------\n\ty(2h)-y(h)=%Lf\n\n", i + 1, calcPoints[i], valuesInPoints[i], valuesInPointsProxy[i], valuesInPointsProxy[i] - valuesInPoints[i]);
	}
	return 0;
}
