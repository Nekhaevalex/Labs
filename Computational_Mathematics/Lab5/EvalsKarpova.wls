#!/usr/bin/env wolframscript
(* ::Package:: *)

Print["Analytic solution:"]
AnalyticEval[x_,t_]:=N[-(1/2) E^-t (2 E^t t - 2 x - E^t x^2)];
L=10;
trail=Table[AnalyticEval[x,1],{x,0,1,1/L}];
Print[trail]
T=0;
K=1;
H=1/(L+1);
DT=N[K*H];
DTX=N[DT/H];
ClearAll[u];
u={0,0,0,0,0,0,0,0,0,0,0};
For[l = 1, l <= L + 1, l++,
 u[[l]] = N[1/L*(l - 1) + 0.5*(1/L*(l - 1))^2];
]
Print[u]
While[N[T+DT] <= 1,
    For[l=11,l>=4,l--,
        x=l/L;
        u[[l]] = u[[l]]+DTX/(6H) (Exp[T]-DTX/2 (1-DTX/3)*x+x)(2 u[[l-3]]-9 u[[l-2]]+18 u[[l-1]]-11 u[[l]])+DTX^2/(2H^2) (x+Exp[T])(x+Exp[T]-DTX*x)(-u[[l-3]]+4u[[l-2]]-5u[[l-1]]+2u[[l]])-(DTX^3 (x+Exp[T]))/(6H^3) (-u[[l-3]]+3u[[l-2]]-3u[[l-1]]+u[[l]])+DTX*(x(x+Exp[T])-DTX/2 (Exp[2T]+2 x Exp[T]+2x^2)+(DTX^2 x)/6*(4x+3Exp[T]));
    ];
    T += DT;
    u[[3]]=0;
    u[[3]]=N[-T+2*Exp[-T]*H+2*H^2];
    u[[2]]=0;
    u[[2]]=N[-T+Exp[-T]*H+H^2/2];
    u[[1]]=0;
    u[[1]]=N[-T];
    Print[u[[3]],u[[2]],u[[1]]]
    DT = N[K*H/Exp[T]];
    DTX = N[DT/H];
];
DT=1-T;
DTX=DT/H;
For[l=11,l>=4,l--,
    x=l/L;
    u[[l]] = u[[l]]+DTX/(6H) (Exp[T]-DTX/2 (1-DTX/3)*x+x)(2 u[[l-3]]-9 u[[l-2]]+18 u[[l-1]]-11 u[[l]])+DTX^2/(2H^2) (x+Exp[T])(x+Exp[T]-DTX*x)(-u[[l-3]]+4u[[l-2]]-5u[[l-1]]+2u[[l]])-(DTX^3 (x+Exp[T]))/(6H^3) (-u[[l-3]]+3u[[l-2]]-3u[[l-1]]+u[[l]])+DTX*(x(x+Exp[T])-DTX/2 (Exp[2T]+2 x Exp[T]+2x^2)+(DTX^2 x)/6*(4x+3Exp[T]));
];
u[[3]] = N[-1 + 2*Exp[-1]*H + 2*H^2];
u[[2]] = N[-1 + Exp[-1]*H + H^2/2];
u[[1]] = N[-1];
Print["Numerical solution:"]
Print[u];
diff=Abs[u-trail];
Print["Max diff:"]
Print[Max[diff]]
Input[]



