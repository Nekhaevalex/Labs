#!/usr/bin/env wolframscript
Print["Lab 5. Nekhaev Alexander 654 gr"]
AnalyticEval[x_, t_] := N[Cos[2*t + x]]; 
L = 20480; 
trail = Table[AnalyticEval[x, 1], {x, 0, 1, 1/L}];
Print["Trail:"]
Print[trail]

ClearAll[numerical]
h = 1/L; 
\[Tau] = h*1.5; 
Nm = Round[1/\[Tau]]; 
dt = \[Tau]/h; 
numerical = Table[0, {t, Nm + 1}, {x, L + 1}]; 
For[l = 1, l <= L + 1, l++, numerical[[1,l]] = N[Cos[(1/L)*l]]; ]

For[n = 1, n <= Nm + 1, n++, numerical[[n,L - 1]] = Cos[1. + 2.*n*\[Tau]]*(1. - 2.*h^2) + (2.*h - 4.*(h^3/3))*Sin[1. + 2.*n*\[Tau]]; 
   numerical[[n,L]] = Cos[1. + 2.*n*\[Tau]]*(1. - h^2/2) + (h - 4.*(h^3/6))*Sin[1. + 2.*n*\[Tau]]; numerical[[n,L + 1]] = N[Cos[1 + 2*\[Tau]*n]]; ]

For[n = 1, n <= Nm, n++, For[l = 1, l <= L - 2, l++, numerical[[n + 1,l]] = numerical[[n,l]] + (\[Tau]/(3*h))*(2*numerical[[n,l + 3]] - 9*numerical[[n,l + 2]] + 18*numerical[[n,l + 1]] - 11*numerical[[n,l]]) + 
     ((2*\[Tau]^2)/h^2)*(-numerical[[n,l + 3]] + 4*numerical[[n,l + 2]] - 5*numerical[[n,l + 1]] + 2*numerical[[n,l]]) + 
     ((4*\[Tau]^3)/(3*h^3))*(numerical[[n,l + 3]] - 3*numerical[[n,l + 2]] + 3*numerical[[n,l + 1]] - numerical[[n,l]])]]

\[Tau] = 1 - Nm*\[Tau]; 
For[l = 1, l <= L - 2, l++, numerical[[Nm + 1,l]] = numerical[[Nm,l]] + (\[Tau]/(3*h))*(2*numerical[[Nm,l + 3]] - 9*numerical[[Nm,l + 2]] + 18*numerical[[Nm,l + 1]] - 11*numerical[[Nm,l]]) + 
     ((2*\[Tau]^2)/h^2)*(-numerical[[Nm,l + 3]] + 4*numerical[[Nm,l + 2]] - 5*numerical[[Nm,l + 1]] + 2*numerical[[Nm,l]]) + 
     ((4*\[Tau]^3)/(3*h^3))*(numerical[[Nm,l + 3]] - 3*numerical[[Nm,l + 2]] + 3*numerical[[Nm,l + 1]] - numerical[[Nm,l]]); ]
numerical[[Nm + 1,L - 1]] = Cos[3]*(1. - 2.*h^2) + (2.*h - 4.*(h^3/3))*Sin[3]; 
numerical[[Nm + 1,L]] = Cos[3]*(1. - h^2/2) + (h - 4.*(h^3/6))*Sin[3]; 
numerical[[Nm + 1,L + 1]] = N[Cos[3]];
Print["Numerical:"]
Print[N[numerical[[n, All]]]]
Print["Max diff"]
Print[Max[Abs[numerical[[n,All]]-trail]]]
Input[]