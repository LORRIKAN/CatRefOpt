using Model.CatRef;
using Researcher.Shared;
using Researcher.Shared.Messages.VisOptimMsgs;
using Researcher.View.InterfaceElements.ParamsIO;
using WinFormsShared;

namespace Researcher.View
{
    public partial class ResearcherForm
    {
        public event Func<Form_Presenter_Optim_Msg, Presenter_Form_Optim_Msg> StartOptimization = null!;
        private void startOptimButt_Click(object sender, EventArgs e)
        {
            var processInputParams = variableParamsOptim.InputParams
                .OfType<VariableParameterWithValue>().ToArray();

            var optimParams = this.optimParams.Controls.OfType<ParameterInput>()
                .Select(pi => pi.Parameter).OfType<Parameter>().Where(p => p.Value is not null).ToArray();

            var variableParams = startingPointOptim.Controls.OfType<VariableParameterInput>()
                .Select(vpi => vpi.Parameter).OfType<VariableParameterWithValue>()
                .ToArray();

            var fromMsg = new Form_Presenter_Optim_Msg
            {
                Catalyst = (Catalyst)catalystOptim.SelectedItem,
                Material = (Material)materialOptim.SelectedItem,
                Plant = (Plant)plantOptim.SelectedItem,
                ProcessInputParams = processInputParams,
                VariableParams = variableParams,
                OptimMethod = (MatlabOptimizationMethod)optimMethod.SelectedItem,
                ParamsOfOptimMethod = optimParams,
                TargetFunc = targetFuncChoosePanel.TargetFunc!,
                FoFunc = targetFuncChoosePanel.FoFunc!,
                Fo = targetFuncChoosePanel.Fo.Value!.Value,
                MathModel = targetFuncChoosePanel.MathModel!
            };

            Task<Presenter_Form_Optim_Msg> optimTask = Task.Run(() => StartOptimization(fromMsg));

            async IAsyncEnumerable<(string message, bool error, bool cancelable)> StartOptim()
            {
                yield return ("Идёт процесс оптимизации...", false, false);
                var result = await optimTask;
                if (!string.IsNullOrEmpty(result.ErrorMsg) || optimTask.IsFaulted)
                    yield return (result.ErrorMsg ?? optimTask?.Exception?.Message ?? "Произошла неизвестная ошибка",
                        true, false);
            }

            var dialogRes = MessageDialog.ShowMarqueeAwaitDialog(StartOptim, this, "Процесс оптимизации", $"{fromMsg.OptimMethod.Name}", aboveAll: true);

            if (dialogRes != TaskDialogButton.OK)
                return;

            async IAsyncEnumerable<(int progressVal, string? progressStr, bool error, bool cancelable)> DrawResults()
            {
                var result = await optimTask;
                bool error = false;

                yield return (0, "Заполнение панели результатов оптимизации...", false, false);
                try
                {
                    var optimResults = ParamsIOGetter.GetParamsOutputs(new[] { result.TFMaxValue, result.FoValue }
                        .Concat(result.ParamsOptimValues));
                    optimResultsPanel.Controls.Clear();
                    optimResultsPanel.Controls.AddRange(optimResults.ToArray());
                }
                catch { error = true; }
                if (error)
                    yield return (0, "Произошла ошибка при заполнении панели результатов оптимизации", true, false);

                yield return (1, "Заполнение панели показателей работы метода оптимизации...", false, false);
                try
                {
                    var methodMetrics = ParamsIOGetter.GetParamsOutputs(result.MethodMetrics);
                    optimMetricsPanel.Controls.Clear();
                    optimMetricsPanel.Controls.AddRange(methodMetrics.ToArray());
                }
                catch { error = true; }
                if (error)
                    yield return (1, "Произошла ошибка при заполнении панели показателей работы метода оптимизации", true, false);

                yield return (2, "Заполнение таблицы пути решения...", false, false);
                try
                {
                    static string MU(MeasureUnit? mu) =>
                        MUStr(mu?.Designation);

                    static string MUStr(string? mu) =>
                        string.IsNullOrEmpty(mu) ? string.Empty : $", {mu}";

                    tableOfPath.Columns.Clear();
                    tableOfPath.Columns.Add("it", "Итерация метода");
                    tableOfPath.Columns.Add("TFValues",
                        $"Значение целевой функции ({fromMsg.TargetFunc.Name}){MU(fromMsg.TargetFunc.MeasureUnit)}");
                    tableOfPath.Columns.Add("FoValues",
                        $"Значение критериального ограничения ({fromMsg.FoFunc.Name}){MU(fromMsg.FoFunc.MeasureUnit)}");

                    for (int i = result.XValuesSolution.Keys.Count - 1; i >= 0; i--)
                    {
                        var param = result.XValuesSolution.Keys.ElementAt(i);
                        tableOfPath.Columns.Insert(1,
                            new DataGridViewTextBoxColumn
                            {
                                HeaderText = $"{param.Name}{MUStr(param.MeasureUnit)}"
                            });
                    }

                    var XTFFoValuesSolution = result.XValuesSolution.Values.Concat(new[]
                    {
                    result.FValues,
                    result.FoValues
                    }).ToArray();

                    for (int i = 0; i < XTFFoValuesSolution[0].Length; i++)
                        tableOfPath.Rows.Add(new[] { i.ToString() }.Concat(XTFFoValuesSolution.Select(ar => ar[i].ToString("F2"))).ToArray());
                }

                catch { error = true; }
                if (error)
                    yield return (2, "Произошла ошибка при заполнение таблицы пути решения", true, false);
            }

            MessageDialog.ShowNormalAwaitDialog(DrawResults, 0, 2, this, "Процесс оптимизации",
                $"{fromMsg.OptimMethod.Name}", aboveAll: true);

            optimPageTab.SelectedTab = optimResultsPage;
            build2DPathButt.ValidatableContainerLogic.TryValidate();
            build3DPathButt.ValidatableContainerLogic.TryValidate();
            saveOptimResultsButt.Enabled = true;
        }
    }
}
