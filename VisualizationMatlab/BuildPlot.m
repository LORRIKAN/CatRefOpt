function BuildPlot(xyd, xl, xu, xLbl, yl, yu, yLbl, zLbl, Title, InDs, InVs, EcDs, EcVs, TFName, TFPath, ...
    SharedFuncsPath, Is3D, Visible)
addpath(genpath(SharedFuncsPath));

addpath(genpath(TFPath));
TFFunc=str2func(TFName);

In=GetMapOfParams(InDs, InVs);
Ec=GetMapOfParams(EcDs, EcVs);

if Visible
    visible='on';
else
    visible='off';
end
figure('Name',Title,'NumberTitle','off', 'Visible',visible);

if Is3D
    Build3DPlot(xl,xu,xLbl,yl,yu,yLbl,zLbl,Title,@TFEval);
else
    Build2DPlot(xl,xu,xLbl,yl,yu,yLbl,Title,@TFEval);
end

    function [val] = TFEval(x)
        val=TFFunc([GetMapOfParams(xyd,x);In],Ec);
    end
end

function Build2DPlot(xl, xu, xLbl, yl, yu, yLbl, Title, TF)
[X,Y,Z] = GetFuncValuesForPlot(xl,xu,yl,yu,TF);
contour(X,Y,Z, 'ShowText','on');
xlabel(xLbl);
ylabel(yLbl);
title(Title);
end

function Build3DPlot(xl, xu, xLbl, yl, yu, yLbl, zLbl, Title, TF)
[X,Y,Z] = GetFuncValuesForPlot(xl,xu,yl,yu,TF);
surf(X,Y,Z);
grid on
shading interp
colormap jet
colorbar
xlabel(xLbl);
ylabel(yLbl);
zlabel(zLbl);
title(Title);
end

function [X,Y,Z] = GetFuncValuesForPlot(xl, xu, yl, yu, TF)
x=linspace(xl,xu,100);
y=linspace(yl,yu,100);
[X,Y]=meshgrid(x,y);
Z=arrayfun(@(x,y)TF([x y]),X,Y);
end