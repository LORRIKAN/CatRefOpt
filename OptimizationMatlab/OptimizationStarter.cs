using MatlabBase;
using MatlabBase.Types.Interfaces;
using MatlabBase.Types.Classes;
using System.Text.RegularExpressions;

namespace OptimizationMatlab
{
    public static class OptimizationStarter
    {
        private static MLApp.MLApp Matlab => MatlabGetter.Matlab!;

        public static OptimResult StartOptimization(OptimInput optimInput)
        {
            IVariableParameterWithValue[] variableParams = optimInput.VariableParams;
            var VPDs = variableParams.Select(vp => vp.Designation).ToArray();
            var VPLBs = variableParams.Select(vp => vp.LowerBound).ToArray();
            var VPUBs = variableParams.Select(vp => vp.UpperBound).ToArray();
            var P0 = variableParams.Select(vp => vp.Value).ToArray();

            IParameterWithValue[] inputParams = optimInput.InputParams;
            var InDs = inputParams.Select(input => input.Designation).ToArray();
            var InVs = inputParams.Select(input => input.Value).ToArray();

            IParameterWithValue[] empiricalCoefficients = optimInput.EmpiricalCoefficients;
            var EcDs = empiricalCoefficients.Select(ec => ec.Designation).ToArray();
            var EcVs = empiricalCoefficients.Select(ec => ec.Value).ToArray();

            IParameterWithValue[] paramsOfOptimMethod = optimInput.ParamsOfOptimMethod;
            var OMPDs = paramsOfOptimMethod.Select(p => p.Designation).ToArray();
            var OMPVs = paramsOfOptimMethod.Select(p => p.Value).ToArray();

            static string WriteFuncToFileAndGetName(string funcText, Regex pattern)
            {
                using var reader = new StringReader(funcText);
                string funcName = pattern.Replace(reader.ReadLine()!, "${funcName}");

                using var writer = new StreamWriter($@".\{funcName}.m");
                writer.Write(funcText);
                return funcName;
            }

            OptimResult result;
            string? TFName = default;
            string? FoFName = default;
            string? OMName = default;
            try
            {
                var pattern = new Regex(@"\s*function\s*\[\s*\w+\s*]\s*=\s*(?<funcName>\w+)\(\s*\w+\s*,\s*\w+\s*\)\s*");
                TFName = WriteFuncToFileAndGetName(optimInput.TargetFunc.MatlabFuncText, pattern);
                FoFName = WriteFuncToFileAndGetName(optimInput.FoFunc.MatlabFuncText, pattern);
                string TFFoFPath = $"'{Path.GetFullPath(@".\")}'";

                pattern = new Regex(@"\s*function\s*\[(\s*\w+\s*,){7}\s*\w+\s*\]\s*=\s*(?<funcName>\w+)\((\s*\w+\s*,){6}\s*\w+\s*\)\s*");
                OMName = WriteFuncToFileAndGetName(optimInput.OptimMethod.MatlabText, pattern);
                string OMPath = TFFoFPath;

                string sharedFuncsPath = SharedFuncs.Path;

                double Fo = optimInput.Fo;

                Matlab.Execute("clear functions");
                Matlab.Execute($"addpath({TFFoFPath})");
                Matlab.Feval("StartOptimization", 11, out object resTmp, VPDs,
                    VPLBs, VPUBs, P0, InDs, InVs, EcDs, EcVs, OMPDs, OMPVs, TFName, TFFoFPath,
                    OMName, OMPath, sharedFuncsPath, FoFName, Fo);

                var res = (object[])resTmp;
                var errorMsg = (string?)res[10];
                double FoValue = Fo;
                if (!string.IsNullOrEmpty(errorMsg))
                        return new OptimResult { ErrorMsg = errorMsg };

                FoValue = (double)res[2];
                IParameterWithValue[] paramsOptimValues = variableParams
                    .Select((v, i) => new ParameterWithValue
                    {
                        Designation = v.Designation,
                        MeasureUnit = v.MeasureUnit,
                        Name = v.Name,
                        Value = res[0] is not double[,] optimValues ? (double)res[0] : optimValues[0, i]
                    }).ToArray();

                var TFMaxValue = (double)res[1];
                var methodIterationsCount = (int)(double)res[3];
                var funcEvalsCount = (int)(double)res[4];
                var eps = res[5] as double?;
                var elapsedTimeInSec = (double)res[6];

                var xValues = (double[,])res[7];
                var xValuesSolution = new Dictionary<IParameter, double[]>();
                for (int i = 0; i < paramsOptimValues.Length; i++)
                {
                    var length = xValues.GetLength(0);
                    var variableParamValues = new double[length];
                    for (int j = 0; j < length; j++)
                        variableParamValues[j] = xValues[j, i];

                    xValuesSolution.Add(paramsOptimValues[i], variableParamValues);
                }

                var FValues = res[8] is double[,] ? ((double[,])res[8]).Cast<double>().ToArray() : new double[] { (double)res[8] };
                var FoValues = res[9] is double[,]? ((double[,])res[9]).Cast<double>().ToArray() : new double[] { (double)res[9] };

                result = new OptimResult
                {
                    ElapsedTimeInSec = elapsedTimeInSec,
                    ErrorMsg = errorMsg,
                    FoValues = FoValues,
                    FuncEvalsCount = funcEvalsCount,
                    FValues = FValues,
                    MethodIterationsCount = methodIterationsCount,
                    ParamsOptimValues = paramsOptimValues,
                    TFMaxValue = TFMaxValue,
                    XValuesSolution = xValuesSolution,
                    FoValue = FoValue,
                    Eps = eps
                };
            }
            catch (Exception ex)
            {
                result = new OptimResult { ErrorMsg = ex.Message };
            }

            static void DeleteFile(string? name)
            {
                if (!string.IsNullOrEmpty(name))
                    File.Delete($@".\{name}.m");
            }
            DeleteFile(TFName);
            DeleteFile(FoFName);
            DeleteFile(OMName);

            return result;
        }
    }
}
