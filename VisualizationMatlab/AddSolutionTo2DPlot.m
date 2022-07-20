function AddSolutionTo2DPlot(X, Y, Title)
x0=X(1);
y0=Y(1);
xend=X(end);
yend=Y(end);
hold on
plot(X, Y,'black.', X, Y, 'red-');
text(x0, y0, 'x0');
text(xend, yend, 'xend');
title(Title);
set(gcf,'Name',Title);
hold off;
end