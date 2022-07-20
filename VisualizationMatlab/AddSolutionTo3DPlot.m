function AddSolutionTo3DPlot(X, Y, Z, Title)
x0=X(1);
y0=Y(1);
z0=Z(1);
xend=X(end);
yend=Y(end);
zend=Z(end);
hold on
plot3(X, Y, Z,'red.', X, Y, Z,'black-');
text(x0, y0, z0, 'x0');
text(xend, yend, zend, 'xend');
title(Title);
set(gcf,'Name',Title);
hold off;
end