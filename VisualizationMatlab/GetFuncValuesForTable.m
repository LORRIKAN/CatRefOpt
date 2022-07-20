function [Z, xDelta, yDelta] = GetFuncValuesForTable(xyd, xl, xu, yl, yu, N, M, InDs, InVs, EcDs, EcVs, TFName, TFPath, ...
    SharedFuncsPath)
addpath(genpath(SharedFuncsPath));

addpath(genpath(TFPath));
TFFunc=str2func(TFName);

In=GetMapOfParams(InDs, InVs);
Ec=GetMapOfParams(EcDs, EcVs);

x=linspace(xl,xu,N);
y=linspace(yl,yu,M);
xDelta=x(2)-x(1);
yDelta=y(2)-y(1);

[Y,X]=meshgrid(y,x);
Z=arrayfun(@(y,x)TFEval([x y]),Y,X);

    function [val] = TFEval(x)
        val=TFFunc([GetMapOfParams(xyd,x);In],Ec);
    end
end