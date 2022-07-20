using Model.CatRef;
using Researcher.Shared;
using Researcher.Shared.Messages.VisOptimMsgs;
using Researcher.View.InterfaceElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsShared;

namespace Researcher.View
{
    public partial class ResearcherForm
    {
        public event Func<Form_Presenter_BuildPlot_Msg, string?> StartVisualization = null!;

        public event Func<Form_Presenter_BuildTableOfValues_Msg, Presenter_Form_BuildTableOfValues_Msg> BuildValuesTable = null!;

        public event Func<bool, string?> BuildPathPlot = null!;

        public event Func<bool> CanBuildPathPlot = null!;

        private void PathPlot(bool is3D)
        {
            Task<string?> visTask = Task.Run(() => BuildPathPlot(is3D));

            async IAsyncEnumerable<(string message, bool error, bool cancelable)> StartVis()
            {
                yield return ("Идёт процесс визуализации...", false, false);
                var err = await visTask;
                if (!string.IsNullOrEmpty(err) || visTask.IsFaulted)
                    yield return (err ?? visTask?.Exception?.Message ?? "Произошла неизвестная ошибка",
                        true, false);
            }

            MessageDialog.ShowMarqueeAwaitDialog(StartVis, this, "Процесс визуализации",
                is3D ? "Построение пути решения на поверхности отклика" : "Построение пути решения на линиях равных значений",
                aboveAll: true);
        }

        private void build2DPathButt_Click(object sender, EventArgs e)
        {
            PathPlot(false);
        }

        private void build3DPathButt_Click(object sender, EventArgs e)
        {
            PathPlot(true);
        }

        private Form_Presenter_Vis_Msg GetVisMessage()
        {
            var processInputParams = variableParamsVis.InputParams
                .OfType<VariableParameterWithValue>().ToArray();

            var variableParams = variableParamsVis.VariableParams.OfType<VariableParameterWithValue>()
                .ToArray();

            return new Form_Presenter_Vis_Msg
            {
                Catalyst = (Catalyst)catalystVis.SelectedItem,
                Material = (Material)materialVis.SelectedItem,
                Plant = (Plant)plantVis.SelectedItem,
                ProcessInputParams = processInputParams,
                VariableParams = variableParams,
                TargetFunc = (MatlabFunc)targetFuncVis.SelectedItem,
                MathModel = (MatlabMathModel)mathModelVis.SelectedItem
            };
        }

        private void StartVisProcess(bool is3D)
        {
            var visMsg = GetVisMessage();

            var msg = new Form_Presenter_BuildPlot_Msg
            {
                VisMsg = visMsg,
                Is3D = is3D
            };

            Task<string?> visTask = Task.Run(() => StartVisualization(msg));

            async IAsyncEnumerable<(string message, bool error, bool cancelable)> StartVis()
            {
                yield return ("Идёт процесс визуализации...", false, false);
                var err = await visTask;
                if (!string.IsNullOrEmpty(err) || visTask.IsFaulted)
                    yield return (err ?? visTask?.Exception?.Message ?? "Произошла неизвестная ошибка",
                        true, false);
            }

            MessageDialog.ShowMarqueeAwaitDialog(StartVis, this, "Процесс визуализации",
                is3D ? "Построение поверхности отклика" : "Построение линий равных значений",
                aboveAll: true);
        }

        private void build2DPlotButt_Click(object sender, EventArgs e)
        {
            StartVisProcess(false);
        }

        private void build3DPlotButt_Click(object sender, EventArgs e)
        {
            StartVisProcess(true);
        }


        private void buildValuesTableButt_Click(object sender, EventArgs e)
        {
            var visMsg = GetVisMessage();

            var msg = new Form_Presenter_BuildTableOfValues_Msg
            {
                VisMsg = visMsg,
                N = (int)valuesTableSizeN.Parameter!.Value!,
                M = (int)valuesTableSizeM.Parameter!.Value!
            };

            Task<Presenter_Form_BuildTableOfValues_Msg> visTask = Task.Run(() => BuildValuesTable(msg));

            async IAsyncEnumerable<(string message, bool error, bool cancelable)> StartVis()
            {
                yield return ("Идёт построение таблицы значений...", false, false);
                var res = await visTask;
                var err = res.ErrorMsg;
                if (!string.IsNullOrEmpty(err) || visTask.IsFaulted)
                    yield return (err ?? visTask?.Exception?.Message ?? "Произошла неизвестная ошибка",
                        true, false);

                var tableMsg = new TableBuildMessage
                {
                    TargetFunc = msg.VisMsg.TargetFunc,
                    XDelta = res.XDelta,
                    YDelta = res.YDelta,
                    XParam = res.XParam,
                    YParam = res.YParam,
                    FuncValues = res.FuncValues,
                    BuildOnInit = true,
                    ValuesPrecision = 2
                };

                valuesTable.TableBuildMessage = tableMsg;
            }

            var res = MessageDialog.ShowMarqueeAwaitDialog(StartVis, this, "Процесс построения таблицы значений",
                $"Построение таблицы значений \"{visMsg.TargetFunc.Name}\"",
                aboveAll: true);

            if (res == TaskDialogButton.OK)
            {
                valuesTable.Visible = true;
                visPageTab.SelectedTab = valuesTablePage;
            }
        }
    }
}
