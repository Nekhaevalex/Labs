#!/usr/bin/env wolframscript
(* ::Package:: *)

(*Script for generating PDF illustrations*)
points = {{-2 \[Pi], 2}, {-\[Pi], 2}, {0, 2}, {\[Pi], 2}, {2 \[Pi], 
    2}};
adjust = Table[{0, 1}, {i, 5}];
pic = Show[
   Plot[-(1/Sin[x]^2), {x, -7, 7}, PlotRange -> {{-7, 7}, {-10, 10}}, 
    PlotTheme -> "MinimalAxes", PlotStyle -> Black, 
    AxesLabel -> {"r", "V(r)"}], 
   ListPlot[points, PlotMarkers -> {Automatic, Medium}, 
    PlotStyle -> Black],
   ListPlot[points + adjust, 
    PlotMarkers -> "\!\(\*SuperscriptBox[\(Z\), \(+\)]\)", 
    PlotStyle -> Black],
   Graphics[{Arrowheads[{-.03, .03}], Arrow[points[[1 ;; 2]]]}],
   ListPlot[{{0, 0.6}} + {Mean[points[[1 ;; 2]]]}, PlotMarkers -> "a",
     PlotStyle -> Black]
   ];
pic2=Show[
Plot[-10*UnitStep[Cos[2x]-\[Pi]/8],{x,-7,7},ExclusionsStyle->Line,PlotRange -> {{-7, 7}, {-10, 10}}, 
    PlotTheme -> "MinimalAxes", PlotStyle -> Black, 
    AxesLabel -> {"r", "V(r)"}],
ListPlot[points, PlotMarkers -> {Automatic, Medium}, 
    PlotStyle -> Black],
ListPlot[points + adjust, 
    PlotMarkers -> "\!\(\*SuperscriptBox[\(Z\), \(+\)]\)", 
    PlotStyle -> Black],
Graphics[{Arrowheads[{-.03, .03}], Arrow[points[[1 ;; 2]]-{{\[Pi]/5, 5},{\[Pi]/5, 5}}]}],
ListPlot[{Mean[points[[1 ;; 2]]]}-{{\[Pi]/5, 4}}, PlotMarkers -> "a",
     PlotStyle -> Black],
Graphics[{Arrowheads[{-.03, .03}], Arrow[points[[1 ;; 2]]-{{\[Pi]/5, 11},{(4\[Pi])/5, 11}}]}],
ListPlot[{Mean[points[[1 ;; 2]]-{{\[Pi]/5, 10},{(4\[Pi])/5, 10}}]}, PlotMarkers -> "b",
     PlotStyle -> Black],
Graphics[{Arrowheads[{-.03,.03}],Arrow[{{\[Pi]/4,0},{\[Pi]/4,-10}}]}],
ListPlot[{{\[Pi]/2.8,-5}},PlotStyle->Black,PlotMarkers->"\!\(\*SubscriptBox[\(V\), \(0\)]\)"]
];

Export["fig1.pdf", pic];
Export["fig2.pdf", pic2];



