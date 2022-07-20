using ClosedXML.Excel;
using ClosedXML.Excel.Drawings;
using Model.CatRef;
using Researcher.Shared;
using Researcher.View.InterfaceElements;
using VisualizationMatlab;

namespace Researcher.Presenter.Export
{
    public static class ExcelExporter
    {
        public static string? ExportOptimResults(ExportMsgOptim msg)
        {
            using var wb = new XLWorkbook();
            IXLWorksheet ws = wb.AddWorksheet();

            var input = msg.FormMsg;
            var res = msg.PresMsg;
            try
            {
                ws.Cell(1, 1)
                    .SetValue("Результаты процесса оптимизации УИК по оптимизации " +
                    "процесса каталитического риформинга").CellBelow()
                    .ExportPlant(input.Plant)
                    .ExportReactors(input.Plant.Reactors, input.MathModel)
                    .ExportMaterial(input.Material, input.MathModel)
                    .ExportCatalyst(input.Catalyst, input.MathModel);

                var cell = ws.Cell(2, 5)
                    .ExportProcessParamsOptim(input.VariableParams, input.ProcessInputParams);

                cell.ExportModelAndTargetFunc(input.MathModel, msg.ModelDesc, input.TargetFunc, true)
                    .ExportFo(input.FoFunc, input.Fo)
                    .ExportOptimMethod(input.OptimMethod, msg.OptimMethodDesc, input.ParamsOfOptimMethod)
                    .ExportOptimSolution(new[] { res.TFMaxValue, res.FoValue }
                    .Concat(msg.PresMsg.ParamsOptimValues))
                    .ExportOptimMetrics(res.MethodMetrics);

                cell = cell.CellRight(4);
                if (msg.TableOfPath is not null)
                    cell = cell.ExportTableOfPath(msg.TableOfPath);

                if (msg.Path2DMsg is not null)
                    cell = cell.Export2DPathPlot(msg.Path2DMsg.Value, ws);

                if (msg.Path3DMsg is not null)
                    cell = cell.Export3DPathPlot(msg.Path3DMsg.Value, ws);

                ws.Range(ws.Cell(1, 1), ws.Cell(1, 10)).Merge();

                wb.SaveAs(msg.FilePath);
            }
            catch (Exception ex) { return ex.Message; }

            return null;
        }

        public static string? ExportVisResults(ExportMsgVis msg)
        {
            using var wb = new XLWorkbook();
            IXLWorksheet ws = wb.AddWorksheet();

            var input = msg.FormMsg;
            try
            {
                ws.Cell(1, 1)
                    .SetValue("Результаты процесса визуализации УИК по оптимизации " +
                    "процесса каталитического риформинга").CellBelow()
                    .ExportPlant(input.Plant)
                    .ExportReactors(input.Plant.Reactors, msg.MathModel)
                    .ExportMaterial(input.Material, msg.MathModel)
                    .ExportCatalyst(input.Catalyst, msg.MathModel);

                var cell = ws.Cell(2, 5)
                    .ExportProcessParamsVis(input.VariableParams, input.ProcessInputParams);

                cell = cell.ExportModelAndTargetFunc(msg.MathModel, msg.ModelDesc, input.TargetFunc, false);

                if (msg.ValuesTable is not null)
                    cell = cell.ExportTableOfValues(msg.ValuesTable);

                if (msg.Plot2D)
                    cell = cell.ExportPlot(new BuildPlotMsg { Is3D = false, VisMsg = msg.VisMsg }, ws);

                if (msg.Plot3D)
                    cell = cell.ExportPlot(new BuildPlotMsg { Is3D = true, VisMsg = msg.VisMsg }, ws);

                ws.Range(ws.Cell(1, 1), ws.Cell(1, 10)).Merge();

                wb.SaveAs(msg.FilePath);
            }
            catch (Exception ex) { return ex.Message; }

            return null;
        }

        private static string MU(MeasureUnit? mu) =>
                        MU(mu?.Designation);

        static string MU(string? mu) =>
            string.IsNullOrEmpty(mu) ? string.Empty : $", {mu}";

        private static IXLCell ExportPlant(this IXLCell cell, Plant plant)
        {
            cell.SetValue("Установка:");
            cell.CellRight().SetValue(plant.Name);

            return cell.CellBelow();
        }

        private static IXLCell SetInputParamsHeader(this IXLCell cell, int stepLeft, string header = "Характеристики")
        {
            return cell.SetValue(header).CellBelow().CellLeft(stepLeft).SetValue("Название")
                .CellRight().SetValue("Значение").CellRight().SetValue("Единица измерения")
                .CellBelow().CellLeft(2);
        }

        private static IXLCell ExportReactors(this IXLCell cell, IEnumerable<Reactor> reactors, MatlabMathModel mathModel)
        {
            cell = cell.SetValue("Реакторы:");
            foreach (var item in reactors)
            {
                cell = cell.CellBelow().SetValue(item.Name);
                if (item.ReactorParameters.Where(p => p.MathModelId == mathModel.Id).Any())
                {
                    cell = cell.CellRight().SetInputParamsHeader(1);
                    foreach (var param in item.ReactorParameters.Where(p => p.MathModelId == mathModel.Id))
                        cell = cell.SetValue(param.Name).CellRight().SetValue(param.Value)
                            .CellRight().SetValue(param.MeasureUnit?.Designation ?? string.Empty)
                            .CellLeft(2).CellBelow();
                }
            }

            return cell.CellBelow();
        }

        private static IXLCell ExportMaterial(this IXLCell cell, Material material, MatlabMathModel mathModel)
        {
            cell = cell.SetValue($"Сырьё:{material.Name}");
            if (material.MaterialParameters.Where(p => p.MathModelId == mathModel.Id).Any())
            {
                cell = cell.CellRight().SetInputParamsHeader(1);
                foreach (var param in material.MaterialParameters.Where(p => p.MathModelId == mathModel.Id))
                    cell = cell.SetValue(param.Name).CellRight().SetValue(param.Value)
                        .CellRight().SetValue(param.MeasureUnit?.Designation ?? string.Empty)
                        .CellLeft(2).CellBelow();
            }

            return cell.CellBelow();
        }

        private static IXLCell ExportCatalyst(this IXLCell cell, Catalyst catalyst, MatlabMathModel mathModel)
        {
            cell = cell.SetValue($"Катализатор:{catalyst.Name}");
            if (catalyst.CatalystParameters.Where(p => p.MathModelId == mathModel.Id).Any())
            {
                cell = cell.CellRight().SetInputParamsHeader(1);
                foreach (var param in catalyst.CatalystParameters.Where(p => p.MathModelId == mathModel.Id))
                    cell = cell.SetValue(param.Name).CellRight().SetValue(param.Value)
                        .CellRight().SetValue(param.MeasureUnit?.Designation ?? string.Empty)
                        .CellLeft(2).CellBelow();
            }
            else
                cell = cell.CellBelow();

            return cell.CellBelow();
        }

        private static IXLCell SetProcessParamsHeaderOptim(this IXLCell cell)
        {
            return cell.SetValue("Параметры процесса:").CellBelow().SetValue("Название")
                .CellRight().SetValue("Нижняя граница").CellRight().SetValue("Верхняя граница")
                .CellRight().SetValue("Значение как входного параметра").CellRight()
                .SetValue("Значение как стартовой точки").CellRight().SetValue("Единица измерения")
                .CellLeft(5).CellBelow();
        }

        private static IXLCell SetProcessParamsHeaderVis(this IXLCell cell)
        {
            return cell.SetValue("Параметры процесса:").CellBelow().SetValue("Название")
                .CellRight().SetValue("Нижняя граница").CellRight().SetValue("Верхняя граница")
                .CellRight().SetValue("Значение как входного параметра").CellRight()
                .SetValue("Единица измерения").CellLeft(4).CellBelow();
        }

        private static IXLCell ExportProcessParamsOptim(this IXLCell cell,
            IEnumerable<VariableParameterWithValue> varParams,
            IEnumerable<VariableParameterWithValue> inputParams)
        {
            cell = cell.SetProcessParamsHeaderOptim();

            foreach (var item in inputParams)
                cell = cell.SetValue(item.Name).CellRight().SetValue(item.LowerBound).CellRight()
                    .SetValue(item.UpperBound).CellRight().SetValue(item.Value)
                    .CellRight(2).SetValue(item.MeasureUnit).CellLeft(5).CellBelow();

            foreach (var item in varParams)
                cell = cell.SetValue(item.Name).CellRight().SetValue(item.LowerBound).CellRight()
                    .SetValue(item.UpperBound).CellRight(2).SetValue(item.Value)
                    .CellRight().SetValue(item.MeasureUnit).CellLeft(5).CellBelow();

            return cell.CellBelow();
        }

        private static IXLCell ExportProcessParamsVis(this IXLCell cell,
            IEnumerable<VariableParameterWithValue> varParams,
            IEnumerable<VariableParameterWithValue> inputParams)
        {
            cell = cell.SetProcessParamsHeaderVis();

            foreach (var item in inputParams)
                cell = cell.SetValue(item.Name).CellRight().SetValue(item.LowerBound).CellRight()
                    .SetValue(item.UpperBound).CellRight().SetValue(item.Value)
                    .CellRight().SetValue(item.MeasureUnit).CellLeft(4).CellBelow();

            foreach (var item in varParams)
                cell = cell.SetValue(item.Name).CellRight().SetValue(item.LowerBound).CellRight()
                    .SetValue(item.UpperBound).CellRight(2).SetValue(item.MeasureUnit)
                    .CellLeft(4).CellBelow();

            return cell.CellBelow();
        }

        private static IXLCell SetModelAndTargetFuncHeadersOptim(this IXLCell cell)
        {
            return cell.SetValue("Математическая модель:").CellBelow().SetValue("Целевая функция:")
                .CellAbove().CellRight();
        }

        private static IXLCell SetModelAndTargetFuncHeadersVis(this IXLCell cell)
        {
            return cell.SetValue("Математическая модель:").CellBelow().SetValue("Функция визуализации:")
                .CellAbove().CellRight();
        }

        private static IXLCell ExportModelAndTargetFunc(this IXLCell cell,
            MatlabMathModel model, bool exportDesc, MatlabFunc func, bool optim)
        {
            if (optim)
                cell = cell.SetModelAndTargetFuncHeadersOptim();
            else
                cell = cell.SetModelAndTargetFuncHeadersVis();

            cell = cell.SetValue(model.Name).CellBelow().SetValue($"{func.Name}{MU(func.MeasureUnit)}");

            if (exportDesc)
                cell.CellAbove().CellRight().SetValue(model.Description);

            return cell.CellBelow(optim ? 1 : 2).CellLeft();
        }

        private static IXLCell ExportFo(this IXLCell cell, MatlabFunc foFunc, double foVal)
        {
            return cell.SetValue("Критериальное ограничение:").CellRight().SetValue(foFunc.Name)
                .CellRight().SetValue($"{foVal:F2}{MU(foFunc.MeasureUnit)}")
                .CellLeft(2).CellBelow(2);
        }

        private static IXLCell ExportParams(this IXLCell cell, IEnumerable<Parameter> parameters)
        {
            foreach (var param in parameters)
                cell = cell.SetValue(param.Name).CellRight().SetValue(param.Value)
                    .CellRight().SetValue(param.MeasureUnit)
                    .CellLeft(2).CellBelow();

            return cell;
        }

        private static IXLCell ExportOptimMethod(this IXLCell cell, MatlabOptimizationMethod optimMethod,
            bool desc, IEnumerable<Parameter> optimParams)
        {
            cell = cell.SetValue("Метод нелинейного программирования:").CellRight().SetValue(optimMethod.Name)
                .CellLeft();
            if (desc)
                cell.CellRight().SetValue(optimMethod.Description);

            if (optimParams.Any())
            {
                cell = cell.CellBelow().SetInputParamsHeader(0, "Параметры метода:");
                cell = cell.ExportParams(optimParams);
            }
            else
                cell = cell.CellBelow();

            return cell.CellBelow();
        }

        private static IXLCell ExportOptimSolution(this IXLCell cell, IEnumerable<Parameter> results)
        {
            cell = cell.SetInputParamsHeader(0, "Решение задачи оптимизации:");

            cell = cell.ExportParams(results);

            return cell.CellBelow();
        }

        private static IXLCell ExportOptimMetrics(this IXLCell cell, IEnumerable<Parameter> metrics)
        {
            cell = cell.SetInputParamsHeader(0, "Показатели метода нелинейного программирования:");

            cell = cell.ExportParams(metrics);

            return cell.CellBelow();
        }

        private static IXLCell ExportTableOfValues(this IXLCell cell, ValuesTable valuesTable)
        {
            var dataGridView = valuesTable.Data;
            cell = cell.SetValue(valuesTable.TableName).CellBelow().
                SetValue(valuesTable.YLbl).CellRight().SetValue(valuesTable.XLbl).CellBelow();
            foreach (var item in dataGridView.Columns.OfType<DataGridViewColumn>())
                cell = cell.SetValue(double.Parse(item.HeaderText)).CellRight();

            cell = cell.CellLeft(dataGridView.ColumnCount + 1).CellBelow();

            var rows = dataGridView.Rows.OfType<DataGridViewRow>().ToArray();
            for (int i = 0; i < rows.Length; i++)
            {
                cell = cell.SetValue(double.Parse((string)rows[i].HeaderCell.Value)).CellRight();

                for (int j = 0; j < dataGridView.ColumnCount; j++)
                    cell = cell.SetValue(double.Parse((string)dataGridView[j, i].Value)).CellRight();

                cell = cell.CellLeft(dataGridView.ColumnCount + 1).CellBelow();
            }

            return cell.CellBelow();
        }

        private static IXLCell ExportTableOfPath(this IXLCell cell, DataGridView dataGridView)
        {
            cell = cell.SetValue("Путь решения в табличном виде:").CellBelow();
            foreach (var item in dataGridView.Columns.OfType<DataGridViewColumn>())
                cell = cell.SetValue(item.HeaderText).CellRight();

            cell = cell.CellLeft(dataGridView.ColumnCount).CellBelow();

            var rows = dataGridView.Rows.OfType<DataGridViewRow>().ToArray();
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 0; j < dataGridView.ColumnCount; j++)
                    cell = cell.SetValue(double.Parse((string)dataGridView[j, i].Value)).CellRight();

                cell = cell.CellLeft(dataGridView.ColumnCount).CellBelow();
            }

            return cell.CellBelow();
        }

        private static IXLCell ExportPlot(this IXLCell cell, string filePath, IXLWorksheet ws)
        {
            var img = new Bitmap(filePath);
            IXLPicture pict = ws.AddPicture(img);

            pict = pict.MoveTo(cell, ws.Cell(cell.Address.RowNumber + 18, cell.Address.ColumnNumber + 10));
            pict.Placement = XLPicturePlacement.MoveAndSize;
            img.Dispose();
            File.Delete(filePath);

            return pict.BottomRightCell.CellLeft(10).CellBelow(2);
        }

        private static IXLCell Export2DPathPlot(this IXLCell cell, Build2DPathMsg msg, IXLWorksheet ws)
        {
            cell = cell.SetValue($"Путь решения метода оптимизации \"{msg.OptimMethodName}\" на " +
                $"линиях равных значений функции \"{msg.VisMsg.TargetFunc.Name}\"").CellBelow();
            (string? filePath, string? err) = VisualizationStarter.Build2DPathToFile(msg);

            if (!string.IsNullOrEmpty(err))
                throw new Exception(err);

            if (string.IsNullOrEmpty(filePath))
                throw new Exception("При экспорте пути решения возникла ошибка");

            return cell.ExportPlot(filePath!, ws);
        }

        private static IXLCell Export3DPathPlot(this IXLCell cell, Build3DPathMsg msg, IXLWorksheet ws)
        {
            cell = cell.SetValue($"Путь решения метода оптимизации \"{msg.OptimMethodName}\" "
                + $"на поверхности отклика функции \"{msg.VisMsg.TargetFunc.Name}\"").CellBelow();
            (string? filePath, string? err) = VisualizationStarter.Build3DPathToFile(msg);

            if (!string.IsNullOrEmpty(err))
                throw new Exception(err);

            if (string.IsNullOrEmpty(filePath))
                throw new Exception("При экспорте пути решения возникла ошибка");

            return cell.ExportPlot(filePath!, ws);
        }

        private static IXLCell ExportPlot(this IXLCell cell, BuildPlotMsg msg, IXLWorksheet ws)
        {
            cell = cell.SetValue(msg.Is3D ? $"Поверхность отклика функции \"{msg.VisMsg.TargetFunc.Name}\"" :
                $"Линии равных значений функции \"{msg.VisMsg.TargetFunc.Name}\"").CellBelow();
            (string? filePath, string? err) = VisualizationStarter.BuildPlotToFile(msg);

            if (!string.IsNullOrEmpty(err))
                throw new Exception(err);

            if (string.IsNullOrEmpty(filePath))
                throw new Exception("При экспорте графика возникла ошибка");

            return cell.ExportPlot(filePath!, ws);
        }
    }
}