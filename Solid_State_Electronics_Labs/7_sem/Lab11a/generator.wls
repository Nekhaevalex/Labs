#!/usr/bin/env wolframscript
(* ::Package:: *)

ResetDirectory[];
table = Import["data.xlsx"][[1]];
darkReverse=table[[4;;13,1;;2]];
fitDarkReverse=LinearModelFit[darkReverse,x,x];
eqDarkReverse=fitDarkReverse["BestFit"];
plot1=Show[ListPlot[darkReverse,PlotTheme->"Detailed",FrameLabel->{"V, \:0412", "I, \:043c\:043a\:0410"}],Plot[eqDarkReverse,{x,0,darkReverse[[Length[darkReverse],1]]}]];
parDarkReverse=Transpose[Prepend[Transpose[Prepend[fitDarkReverse["ParameterTableEntries"],{"Estimate","Standard Error","t\[Hyphen]Statistic","P\[Hyphen]Value"}]],{"","1","x"}]];
k=Quantity[Around[fitDarkReverse["BestFitParameters"][[2]],fitDarkReverse["ParameterErrors"][[2]]],"Microamperes"]/Quantity[1,"Volts"];
Rsh=UnitSimplify[ScientificForm[1/k]];
Print["\!\(\*SubscriptBox[\(R\), \(\:0448\)]\)=",Rsh]
darkDirectSimple=table[[4;;26,4;;5]];
fitDarkDirectSimple=LinearModelFit[darkDirectSimple[[18;;22,All]],x,x];
eqDarkDirectSimple=fitDarkDirectSimple["BestFit"];
parDarkDirectSimple=Transpose[Prepend[Transpose[Prepend[fitDarkDirectSimple["ParameterTableEntries"],{"Estimate","Standard Error","t\[Hyphen]Statistic","P\[Hyphen]Value"}]],{"","1","x"}]];
plot2=Show[ListPlot[darkDirectSimple,PlotTheme->"Detailed",FrameLabel->{"V, \:0412", "I, \:043c\:043a\:0410"}],Plot[eqDarkDirectSimple,{x,0,1}]];
kp=Quantity[Around[fitDarkDirectSimple["BestFitParameters"][[2]],fitDarkDirectSimple["ParameterErrors"][[2]]],"Microamperes"]/Quantity[1,"Volts"];
Rp=UnitSimplify[ScientificForm[1/kp]];
Print["\!\(\*SubscriptBox[\(R\), \(\:043f\)]\)=",Rp]
darkDirect=Transpose[{table[[4;;26,4]],Log[table[[4;;26,5]]]}];
fitDarkDirect=LinearModelFit[darkDirect,x,x];
eqDarkDirect=fitDarkDirect["BestFit"];
parDarkDirect=Transpose[Prepend[Transpose[Prepend[fitDarkDirect["ParameterTableEntries"],{"Estimate","Standard Error","t\[Hyphen]Statistic","P\[Hyphen]Value"}]],{"","1","x"}]];
plot3=Show[ListPlot[darkDirect,PlotTheme->"Detailed",FrameLabel->{"V, \:0412", "log(I)"}],Plot[eqDarkDirect,{x,0,1}]];
Is=Quantity[Exp[Around[fitDarkDirect["BestFitParameters"][[1]],fitDarkDirect["ParameterErrors"][[1]]]],"Microamperes"];
Print["\!\(\*SubscriptBox[\(I\), \(s\)]\)=",Is]
slope=Quantity[Around[fitDarkDirect["BestFitParameters"][[2]],fitDarkDirect["ParameterErrors"][[2]]],"Microamperes"/"Volts"];
a=UnitSimplify[1/(Quantity[0.025,"Volts"]slope)];
Print["A=",a]
light=table[[4;;22,8;;9]];
fit=Fit[light,{1,x,x^2,x^3,x^4},x];
plot4=Show[ListPlot[light,PlotTheme->"Detailed",FrameLabel->{"V, \:043c\:0412", "I, \:043c\:0410"}],Plot[fit,{x,0,600}]];
Ikz=Quantity[fit/.x->Min[light[[All,1]]],"Microamperes"];
Uxx=Quantity[x/.Solve[0==fit,x][[4,1]],"Millivolts"];
Print["\!\(\*SubscriptBox[\(I\), \(\:043a . \:0437 . \)]\)=",Ikz]
Print["\!\(\*SubscriptBox[\(U\), \(x . x . \)]\)=",Uxx]
dif=D[fit,x];
un=Quantity[N[x/.Solve[dif==-0.05,x][[3,1]]],"Millivolts"];
in=Quantity[fit/.x->QuantityMagnitude[un],"Milliamperes"];
Rotp=un/in;
Print["\!\(\*SubscriptBox[\(I\), \(\:043d\)]\)=",in]
Print["\!\(\*SubscriptBox[\(U\), \(\:043d\)]\)=",un]
Print["\!\(\*SubscriptBox[\(R\), \(\:043e\:043f\:0442\)]\)=",Rotp]
\[Zeta]=(in*un)/(Ikz*Uxx);
pow=UnitConvert[UnitSimplify[\[Zeta]*Uxx*Ikz],"Milliwatts"];
Print["P=",pow]
filters=Transpose[{table[[3;;6,16]],Log[table[[3;;6,17]]]}];
filtersFit=LinearModelFit[filters,x,x];
filtersFitEq=filtersFit["BestFit"];
filtersFitParTab=Transpose[Prepend[Transpose[Prepend[filtersFit["ParameterTableEntries"],{"Estimate","Standard Error","t\[Hyphen]Statistic","P\[Hyphen]Value"}]],{"","1","x"}]];
plot5=Show[ListPlot[filters,PlotTheme->"Detailed",FrameLabel->{"V, \:0412", "log(I)"}],Plot[filtersFitEq,{x,0,0.5}]];
Isf=Quantity[Exp[Around[filtersFit["BestFitParameters"][[1]],filtersFit["ParameterErrors"][[1]]]],"Microamperes"];
Print["\!\(\*SubscriptBox[\(I\), \(s\)]\)=",Isf]
slopef=Quantity[Around[filtersFit["BestFitParameters"][[2]],filtersFit["ParameterErrors"][[2]]],"Microamperes"/"Volts"];
af=UnitSimplify[1/(Quantity[0.025,"Volts"]slope)];
Print["A=",af]
(*Export all*)
Export["plot1.png",plot1,ImageResolution->500];
Export["plot2.png",plot2,ImageResolution->500];
Export["plot3.png",plot3,ImageResolution->500];
Export["plot4.png",plot4,ImageResolution->500];
Export["plot5.png",plot5,ImageResolution->500];
Export["er1.xlsx",parDarkReverse];
Export["er2.xlsx",parDarkDirectSimple];
Export["er3.xlsx",parDarkDirect];
Export["er5.xlsx",filtersFitParTab];
