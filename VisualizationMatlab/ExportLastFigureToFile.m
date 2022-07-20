function ExportLastFigureToFile(filePath)
set(gcf,'PaperPositionMode','auto');
print(filePath,'-dpng','-r0');
end