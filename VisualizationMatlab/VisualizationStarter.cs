using MatlabBase;
using Model.CatRef;
using System.Text.RegularExpressions;

namespace VisualizationMatlab
{
    public static class VisualizationStarter
    {
        private static MLApp.MLApp Matlab => MatlabGetter.Matlab!;

        private static string MU(MeasureUnit? mu) =>
                        MU(mu?.Designation);

        private static string MU(string? mu) =>
            string.IsNullOrEmpty(mu) ? string.Empty : $", {mu}";

        private static string WriteFuncToFileAndGetName(string funcText, Regex pattern)
        {
            using var reader = new StringReader(funcText);
            string funcName = pattern.Replace(reader.ReadLine()!, "${funcName}");

            using var writer = new StreamWriter($@".\{funcName}.m");
            writer.Write(funcText);
            return funcName;
        }

        public static string? BuildPlot(BuildPlotMsg msg)
        {
            return BuildPlot(msg, true);
        }

        private static string? BuildPlot(BuildPlotMsg msg, bool visible)
        {
            var visMsg = msg.VisMsg;
            var xd = visMsg.X.Designation;
            var xl = visMsg.X.LowerBound;
            var xu = visMsg.X.UpperBound;
            var xLbl = $"{visMsg.X.Name}{MU(visMsg.X.MeasureUnit)}";

            var yd = visMsg.Y.Designation;
            var yl = visMsg.Y.LowerBound;
            var yu = visMsg.Y.UpperBound;
            var yLbl = $"{visMsg.Y.Name}{MU(visMsg.Y.MeasureUnit)}";
            var xyd = new[] { xd, yd };

            var zLbl = $"{visMsg.TargetFunc.Name}{MU(visMsg.TargetFunc.MeasureUnit)}";
            var title = visible ? (msg.Is3D ? $"Поверхность отклика функции \"{visMsg.TargetFunc.Name}\"" :
                $"Линии равных значений функции \"{visMsg.TargetFunc.Name}\"") : "";

            var InDs = visMsg.InputParams.Select(p => p.Designation).ToArray();
            var InVs = visMsg.InputParams.Select(p => p.Value).ToArray();

            var EcDs = visMsg.EmpiricalCoeffs.Select(ef => ef.Designation).ToArray();
            var EcVs = visMsg.EmpiricalCoeffs.Select(ef => ef.Value).ToArray();

            var pattern = new Regex(@"\s*function\s*\[\s*\w+\s*]\s*=\s*(?<funcName>\w+)\(\s*\w+\s*,\s*\w+\s*\)\s*");
            var TFName = WriteFuncToFileAndGetName(visMsg.TargetFunc.MatlabFuncText, pattern);
            var TFPath = $"'{Path.GetFullPath(@".\")}'";

            var sharedFuncsPath = SharedFuncs.Path;
            string? err = null;

            Matlab.Execute("clear functions");
            Matlab.Execute($"addpath(genpath({TFPath}))");
            try
            {
                Matlab.Feval("BuildPlot", 0, out _,
                    xyd, xl, xu, xLbl, yl, yu, yLbl, zLbl, title, InDs, InVs,
                    EcDs, EcVs, TFName, TFPath, sharedFuncsPath, msg.Is3D, visible);
            }
            catch (Exception ex) { err = ex.Message; }

            static void DeleteFile(string? name)
            {
                if (!string.IsNullOrEmpty(name))
                    File.Delete($@".\{name}.m");
            }

            DeleteFile(TFName);

            return err;
        }

        private static string? Build2DPathPlot(Build2DPathMsg msg, bool visible)
        {
            string? err = BuildPlot(new BuildPlotMsg { VisMsg = msg.VisMsg, Is3D = false }, visible);
            if (!string.IsNullOrEmpty(err))
                return err;

            var title = visible ? $"Путь решения метода оптимизации \"{msg.OptimMethodName}\" на " +
                $"линиях равных значений функции \"{msg.VisMsg.TargetFunc.Name}\"" : "";
            try
            {
                Matlab.Feval("AddSolutionTo2DPlot", 0, out _,
                    msg.X, msg.Y, title);
            }
            catch (Exception ex) { err = ex.Message; }

            return err;
        }

        public static string? Build2DPathPlot(Build2DPathMsg msg)
        {
            return Build2DPathPlot(msg, true);
        }

        private static string? Build3DPathPlot(Build3DPathMsg msg, bool visible)
        {
            string? err = BuildPlot(new BuildPlotMsg { VisMsg = msg.VisMsg, Is3D = true }, visible);
            if (!string.IsNullOrEmpty(err))
                return err;

            var title = visible ? $"Путь решения метода оптимизации \"{msg.OptimMethodName}\" " 
                + $"на поверхности отклика функции \"{msg.VisMsg.TargetFunc.Name}\"" : "";
            try
            {
                Matlab.Feval("AddSolutionTo3DPlot", 0, out _,
                    msg.X, msg.Y, msg.Z, title);
            }
            catch (Exception ex) { err = ex.Message; }

            return err;
        }

        public static string? Build3DPathPlot(Build3DPathMsg msg)
        {
            return Build3DPathPlot(msg, true);
        }

        public static ValuesTableBuildRes BuildValuesTable(ValuesTableBuildMsg msg)
        {
            var visMsg = msg.VisMsg;

            var xd = visMsg.X.Designation;
            var xl = visMsg.X.LowerBound;
            var xu = visMsg.X.UpperBound;

            var yd = visMsg.Y.Designation;
            var yl = visMsg.Y.LowerBound;
            var yu = visMsg.Y.UpperBound;
            var xyd = new[] { xd, yd };
            var N = msg.N;
            var M = msg.M;

            var InDs = visMsg.InputParams.Select(p => p.Designation).ToArray();
            var InVs = visMsg.InputParams.Select(p => p.Value).ToArray();

            var EcDs = visMsg.EmpiricalCoeffs.Select(ef => ef.Designation).ToArray();
            var EcVs = visMsg.EmpiricalCoeffs.Select(ef => ef.Value).ToArray();

            var pattern = new Regex(@"\s*function\s*\[\s*\w+\s*]\s*=\s*(?<funcName>\w+)\(\s*\w+\s*,\s*\w+\s*\)\s*");
            var TFName = WriteFuncToFileAndGetName(visMsg.TargetFunc.MatlabFuncText, pattern);
            var TFPath = $"'{Path.GetFullPath(@".\")}'";

            var sharedFuncsPath = SharedFuncs.Path;
            ValuesTableBuildRes result;

            Matlab.Execute("clear functions");
            Matlab.Execute($"addpath(genpath({TFPath}))");
            try
            {
                Matlab.Feval("GetFuncValuesForTable", 3, out object resTmp,
                    xyd, xl, xu, yl, yu, N, M, InDs, InVs, EcDs, EcVs, TFName, TFPath, sharedFuncsPath);
                var res = (object[])resTmp;

                result = new ValuesTableBuildRes
                {
                    ErrorMsg = null,
                    FuncValues = (double[,])res[0],
                    XDelta = (double)res[1],
                    YDelta = (double)res[2]
                };
            }
            catch (Exception ex) { result = new ValuesTableBuildRes { ErrorMsg = ex.Message }; }

            static void DeleteFile(string? name)
            {
                if (!string.IsNullOrEmpty(name))
                    File.Delete($@".\{name}.m");
            }

            DeleteFile(TFName);

            return result;
        }

        public static (string? filePath, string? err) BuildPlotToFile(BuildPlotMsg msg)
        {
            string? err = BuildPlot(msg, false);

            if (!string.IsNullOrEmpty(err))
                return (null, err);

            var filePath = $"{Path.GetFullPath(@".\")}Plot";

            try
            {
                Matlab.Feval("ExportLastFigureToFile", 0, out _,
                    filePath);
            }
            catch(Exception ex) { return (null, ex.Message); }

            return ($"{filePath}.png", null);
        }

        public static (string? filePath, string? err) Build2DPathToFile(Build2DPathMsg msg)
        {
            string? err = Build2DPathPlot(msg, false);

            if (!string.IsNullOrEmpty(err))
                return (null, err);

            var filePath = $"{Path.GetFullPath(@".\")}Plot";

            try
            {
                Matlab.Feval("ExportLastFigureToFile", 0, out _,
                    filePath);
            }
            catch (Exception ex) { return (null, ex.Message); }

            return ($"{filePath}.png", null);
        }

        public static (string? filePath, string? err) Build3DPathToFile(Build3DPathMsg msg)
        {
            string? err = Build3DPathPlot(msg, false);

            if (!string.IsNullOrEmpty(err))
                return (null, err);

            var filePath = $"{Path.GetFullPath(@".\")}Plot";

            try
            {
                Matlab.Feval("ExportLastFigureToFile", 0, out _,
                    filePath);
            }
            catch (Exception ex) { return (null, ex.Message); }

            return ($"{filePath}.png", null);
        }
    }
}
