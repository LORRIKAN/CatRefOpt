function[x, F, FoVal, iterations, funcCount, firstorderopt, elapsedTime, xValuesSolution, FValues, FoValues, Er] = StartOptimization(VPDs, VPLBs, VPUBs, ...
    P0, InDs, InVs, EcDs, EcVs, OMPDs, OMPVs, TFName, TFFoFPath, OMName, OMPath, SharedFuncsPath, FoFName, Fo)
addpath(genpath(SharedFuncsPath));

addpath(genpath(TFFoFPath));
TFFunc=str2func(TFName);
FoFFunc=str2func(FoFName);

addpath(genpath(OMPath));
OM=str2func(OMName);

In=GetMapOfParams(InDs, InVs);
Ec=GetMapOfParams(EcDs, EcVs);
OMP=GetMapOfParams(OMPDs, OMPVs);

xValuesSolution=[];
FValues=[];
FoValues=[];
[x, fval, flag, iterations, funcCount, firstorderopt, elapsedTime, Er]=OM(VPLBs,VPUBs,P0,OMP,@TFForOptim,@FoFForOptim,@outfun);
F=-fval;
if(size(FoValues)>0)
    FoVal=FoValues(end);
else
    FoVal=0;
end

    function stop = outfun(x, optimValues, state)
    switch state
        case 'iter'
            xValuesSolution=[xValuesSolution; x];
            FValues=[FValues; -optimValues.fval];
            FoValues=[FoValues; FoFEval(x)];
    end
    end

    function [val] = TFEval(x)
        val=TFFunc([GetMapOfParams(VPDs,x);In],Ec);
    end

    function [val] = FoFEval(x)
        val=FoFFunc([GetMapOfParams(VPDs,x);In],Ec);
    end
    
    function [c,ceq] = FoFForOptim(x)
        c=Fo-FoFEval(x);
        ceq=[];
    end

    function [val] = TFForOptim(x)
        val=-TFEval(x);
    end
end