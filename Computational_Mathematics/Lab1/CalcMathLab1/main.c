#include <stdio.h>
#include <math.h>
#include <stdbool.h>

#define ftype long double

ftype getXY(ftype PN, ftype P0) {
	return PN / P0;
}

ftype getAlpha(ftype gamma) {
	return (gamma + 1.0) / (gamma - 1.0);
}

ftype getE(ftype C, ftype gamma, ftype U3, ftype U0) {
	return (2.0*powf(C, 2.0)) / (gamma*(gamma - 1)*powf((U3 - U0),2));
}

ftype getC(ftype gamma, ftype P, ftype rho) {
	return sqrtf(gamma*(P / rho));
}

ftype getMax(ftype* array, int size) {
	if (size < 1) {
		return -1;
	} else {
		ftype max = array[0];
		for (int i = 1; i<size; i++) {
			if (array[i] > max) {
				max = array[i];
			}
		}
		return max;
	}
}

ftype sign(ftype a) {
	if (a > 0) {
		return 1;
	} else if (a==0) {
		return 0;
	} else {
		return -1;
	}
}

ftype evaluate(ftype *coefs, int length, ftype X) {
	ftype result = 0;
	for (int i = 0; i<length; i++) {
		result+=coefs[i]*pow(X, length-i-1);
	}
	return result;
}

typedef struct {
	ftype left;
	ftype right;
}interval;

void printInterval(interval a) {
	printf("\t%Lf<=X<=%Lf\n",a.left,a.right);
}

int main()
{
	printf("Computational Mathematics Lab #1\nVariant I.1\n(c)2018, Alexander Nekhaev\n\n");
	//Initial values
	ftype gamma0 = 5.0 / 3.0;
	ftype rho0 = 2.71 * powf(10.0, -3.0);
	ftype U0 = -2 * powf(10.0, 5.0);
	ftype P0 = 5.0 * powf(10.0, 5.0);
	
	ftype gamma3 = 5.0 / 3;
	ftype rho3 = 2.71 * powf(10.0, -3.0);
	ftype U3 = 0;
	ftype P3 = 5.0 * powf(10.0, 5.0);
	
	printf("Initial values:\n\tgamma_0=%Lf\n\trho_0=%Lf\n\tU_0=%Lf\n\tP_0=%Lf\n\n\tgamma_3=%Lf\n\trho_3=%Lf\n\tU_3=%Lf\n\tP_3=%Lf\n",gamma0, rho0, U0, P0, gamma3, rho3, U3, P3);
	
	ftype X = getXY(P3, P0);
	ftype alpha0 = getAlpha(gamma0);
	ftype alpha3 = getAlpha(gamma3);
	ftype C0 = getC(gamma0, P0, rho0);
	ftype C3 = getC(gamma3, P3, rho3);
	ftype e3 = getE(C3, gamma3, U3, U0);
	ftype e0 = getE(C0, gamma3, U3, U0);
	
	//Get coefficients
	ftype a0 = powf(alpha0*e3 - alpha3 * e0*X, 2);
	ftype a1 = -2 * (alpha3*e0*X*(e3 + e0 * (2 * alpha3 - X)*X) + e3 * (alpha3 + 2 * e3)*X*powf(alpha0, 2) + alpha0 * (e0*e3*X*(X - 2 * alpha3*(1 + X)) - powf(e3, 2) + e0 * powf(alpha3, 2)*powf(X, 2)));
	ftype a2 = powf(e3, 2)*(1 - 8 * alpha0*X + 6 * powf(alpha0, 2)*powf(X, 2)) + powf(X, 2)*(4 * alpha0*alpha3*e0*(alpha3 - X) + powf(alpha0, 2)*powf(alpha3, 2) + e0 * (-8 * alpha3*e0*X + (-2 + 6 * e0)*powf(alpha3, 2) + e0 * powf(X, 2))) - 2 * e3*X*(e0*X - 2 * alpha3*e0*(1 + X) - 2 * alpha0*e0*X*(1 + X) + (X - 2 * alpha3*X)*powf(alpha0, 2) + alpha0 * alpha3*(2 + e0 * (1 + 4 * X + powf(X, 2))));
	ftype a3 = -2 * X*((-1 + e0)*(alpha0 + 2 * e0)*X*powf(alpha3, 2) + 2 * powf(e3, 2)*(1 - 3 * alpha0*X + powf(alpha0, 2)*powf(X, 2)) + alpha3 * (-((4 * alpha0*e0 + 2 * e0*(-1 + 3 * e0) + powf(alpha0, 2))*powf(X, 2)) + e3 * (1 + e0 - 4 * alpha0*X - 2 * (-2 + alpha0)*e0*X + (1 - 2 * alpha0)*e0*powf(X, 2) + powf(alpha0, 2)*powf(X, 2))) + e3 * X*(-2 * e0*(1 + X) - 2 * X*powf(alpha0, 2) + alpha0 * (2 + e0 * (1 + 4 * X + powf(X, 2)))) + e0 * (alpha0 + 2 * e0)*powf(X, 3));
	ftype a4 = powf(X, 2)*(alpha3*(-4 * (-1 + e0)*(alpha0 + 2 * e0)*X + e3 * (4 - 4 * alpha0*X + e0 * (4 + 4 * X - 2 * alpha0*X))) + powf(alpha3, 2)*powf(-1 + e0, 2) + (4 * alpha0*e0 + 2 * e0*(-1 + 3 * e0) + powf(alpha0, 2))*powf(X, 2) + powf(e3, 2)*(6 - 8 * alpha0*X + powf(alpha0, 2)*powf(X, 2)) - 2 * e3*(1 + e0 - 4 * alpha0*X - 2 * (-2 + alpha0)*e0*X + (1 - 2 * alpha0)*e0*powf(X, 2) + powf(alpha0, 2)*powf(X, 2)));
	ftype a5 = -2 * ((-1 + e0)*(alpha0 + 2 * e0)*X + e3 * (-2 + 2 * alpha0*X + e0 * (-2 + (-2 + alpha0)*X)) + alpha3 * (-1 + e3 + e0 * (2 + e3) - powf(e0, 2)) + (2 - alpha0 * X)*powf(e3, 2))*powf(X, 3);
	ftype a6 = (-2 * e0*(1 + e3) + powf(e0, 2) + powf(-1 + e3, 2))*powf(X, 4);
	
	printf("\nFirst step results(coefficients):\n\ta0=%Lf\n\ta1=%Lf\n\ta2=%Lf\n\ta3=%Lf\n\ta4=%Lf\n\ta5=%Lf\n\ta6=%Lf\n", a0, a1, a2, a3, a4, a5, a6);
	
	//Root localization
	ftype arrayOneToN[6] = {a1, a2, a3, a4, a5, a6};
	ftype arrayZeroToNMinOne[6] = {a0, a1, a2, a3, a4, a5};
	
	ftype A = getMax(arrayOneToN, 6);
	ftype B = getMax(arrayZeroToNMinOne, 6);
	
	ftype leftEdge = fabsl(a6)/(fabsl(a6) + B);
	ftype rightEdge = 1 + (A/fabsl(a0));
	
	printf ("\nSecond step result(localization):\nRing:\n\t%Lf<=|z|<=%Lf\n", leftEdge, rightEdge);
	
	ftype M = 640000;
	ftype step = (rightEdge-leftEdge)/M;
	interval intervals[6];
	int intervalsAmount = 0;
	int lastSign;
	ftype coefs[7] = {a0, a1, a2, a3, a4, a5, a6};
	
	bool repeated = false;
	printf("Initial segment amount (M): %Lf\n", M*2);
	while (intervalsAmount<2) {
		if (repeated == true) {
			printf("***Message***\nRoots not found\nIncreasing M to %Lf\n*************\n", M*2);
		}
		M = M*2;
		step = (rightEdge-leftEdge)/M;
		for  (int i = 0;i < 6; i++) {
			lastSign = sign(evaluate(coefs, 7, -rightEdge));
			intervalsAmount = 0;
			for (ftype X = (-1)*rightEdge; X<=(-1)*leftEdge; X+=step) {
				if (sign(evaluate(coefs, 7, X)) != lastSign) {
					lastSign = sign(evaluate(coefs, 7, X));
					intervalsAmount++;
					intervals[intervalsAmount-1].left = X-step;
					intervals[intervalsAmount-1].right = X;
				}
			}
			lastSign = sign(evaluate(coefs, 7, leftEdge));
			
			for (ftype X = leftEdge; X<=rightEdge; X+=step) {
				if (sign(evaluate(coefs, 7, X)) != lastSign) {
					lastSign = sign(evaluate(coefs, 7, X));
					intervalsAmount++;
					intervals[intervalsAmount-1].left = X-step;
					intervals[intervalsAmount-1].right = X;
				}
			}
		}
		repeated = true;
	}
	
	printf("Intervals:\n");
	for (int i = 0; i<intervalsAmount; i++) {
		printInterval(intervals[i]);
	}
	
	printf("Third step result(clarification):\nDichotomy:\nInput epsilon: ");
	ftype epsilon = 0.0;
	ftype roots[intervalsAmount];
	scanf("%Lf", &epsilon);
	for (int i = 0; i<6; i++) {
		ftype l = intervals[i].left;
		ftype r = intervals[i].right;
		while ((r-l) > epsilon) {
			ftype middle = (l+r)/2.0;
			
			ftype leftValue = evaluate(coefs, 7, l);
			ftype middleValue = evaluate(coefs, 7, middle);
			
			ftype testVal = leftValue*middleValue;
			
			if (testVal < 0) {
				r = middle;
			} else {
				l = middle;
			}
		}
		ftype root = (l+r)/2.0;
		roots[i] = root;
		printf("Root number %d x = %Lf\n", i, root);
	}
	printf("\nFourth step result(D0 and D3):");
	printf("\n(We need only positive roots)\n\n");
	for (int i = 0; i<6; i++) {
		if (roots[i] > 0) {
			printf("Root Y[%d]=%Lf\n",i,roots[i]);
			printf("---------------------------\n");
			
			//Adapter
			ftype G0 = gamma0;
			ftype R0 = rho0;
			//U0 remains the same
			//P0 remains the same
			ftype G1 = gamma3;
			ftype R1 = rho3;
			ftype U1 = U3;
			ftype P1 = P3;
			
			ftype Y = roots[i];
			ftype P3 = Y * P0;
			ftype P2 = P3;
			ftype R3 = R0 * (G0 - 1.0 + (G0 + 1.0) * Y) / (G0 + 1.0 + (G0 - 1.0) * Y);
			ftype U3 = U0 + sqrtl((P3 - P0) * (R3 - R0) / (R3 * R0));
			ftype R2 = R1 * ((G1 + 1.0) * P2 + (G1 - 1.0) * P1) / ((G1 - 1.0) * P2 + (G1 + 1.0) * P1);
			ftype U2 = U1 - sqrtl((P2 - P1) * (R2 - R1) / (R2 * R1));
			ftype D0 = (R3 * U3 - R0 * U0) / (R3 - R0);
			ftype D1 = (R2 * U2 - R1 * U1) / (R2 - R1);
			ftype C2 = sqrtl(G1 * P2 / R2);
			ftype C3 = sqrtl(G0 * P3 / R3);
			ftype Z0 = (P3 - P0) / fabsl(U3 - U0);
			ftype Z1 = (P2 - P1) / fabsl(U2 - U1);
			
			ftype aCriticalSquare = (P3-P0)/(R3-R0);
			ftype lambda1 = (U3-D0)/sqrt(aCriticalSquare);
			ftype lambda2 = (U0-D0)/sqrt(aCriticalSquare);
			
			printf("\tD0=%Lf\t\n\tD3=%Lf\n\nAdditional data\n\n\tA_Critical^2=%Lf\n\tLambda_1=%Le\n\tLambda2=%Le\n\tTest: (%Le)*(%Le)=(%Lf)\n\n", D0, D1, aCriticalSquare, lambda1, lambda2, lambda1, lambda2, lambda1*lambda2);
		}
	}
	return 0;
}
