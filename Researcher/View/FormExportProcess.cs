using Model.CatRef;
using Researcher.Shared.Messages.ExportMsgs;
using Researcher.View.InterfaceElements;
using WinFormsShared;

namespace Researcher.View
{
    public partial class ResearcherForm
    {

        public event Func<Form_Presenter_SaveOptimResults_Msg, string?> SaveOptimResults = null!;

        public event Func<Form_Presenter_SaveVisResults_Msg, string?> SaveVisResults = null!;
        private void saveOptimResultsButt_Click(object sender, EventArgs e)
        {
            var optionalItems = new OptimResultsSaveForm().Run(CanBuildPathPlot());
            if (optionalItems is null || saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = saveFileDialog.FileName;
            var msg = new Form_Presenter_SaveOptimResults_Msg
            {
                FilePath = filePath,
                OptionalItemsToSave = optionalItems.Value,
                TableOfPath = tableOfPath
            };

            Task<string?> saveTask = Task.Run(() => SaveOptimResults(msg));

            async IAsyncEnumerable<(string message, bool error, bool cancelable)> SaveResults()
            {
                yield return ("Идёт сохранение результатов оптимизации в файл...", false, false);
                var err = await saveTask;
                if (!string.IsNullOrEmpty(err) || saveTask.IsFaulted)
                    yield return (err ?? saveTask?.Exception?.Message ?? "Произошла неизвестная ошибка",
                        true, false);
            }

            var res = MessageDialog.ShowMarqueeAwaitDialog(SaveResults, this, "Сохранение результатов в файл",
                "Процесс сохранения результатов оптимизации в файл", aboveAll: true);

            if (res == TaskDialogButton.OK)
                MessageDialog.ShowMessage(MessageType.Success, this, "Сохранение результатов в файл",
                    "Процесс сохранения результатов оптимизации в файл", "Сохранение прошло успешно");
        }

        private void saveVisResultsButt_Click(object sender, EventArgs e)
        {
            var optionalItems = new VisResultsSaveForm().Run(build2DPlotButt.ValidatableControlLogic.Validated
                , valuesTable.TableBuilt);

            if (optionalItems is null || saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string filePath = saveFileDialog.FileName;
            var visMsg = GetVisMessage();
            var msg = new Form_Presenter_SaveVisResults_Msg
            {
                FilePath = filePath,
                OptionalItemsToSave = optionalItems.Value,
                ValuesTable = valuesTable,
                VisMsg = visMsg,
            };

            Task<string?> saveTask = Task.Run(() => SaveVisResults(msg));

            async IAsyncEnumerable<(string message, bool error, bool cancelable)> SaveResults()
            {
                yield return ("Идёт сохранение результатов визуализации в файл...", false, false);
                var err = await saveTask;
                if (!string.IsNullOrEmpty(err) || saveTask.IsFaulted)
                    yield return (err ?? saveTask?.Exception?.Message ?? "Произошла неизвестная ошибка",
                        true, false);
            }

            var res = MessageDialog.ShowMarqueeAwaitDialog(SaveResults, this, "Сохранение результатов в файл",
                "Процесс сохранения результатов визуализации в файл", aboveAll: true);

            if (res == TaskDialogButton.OK)
                MessageDialog.ShowMessage(MessageType.Success, this, "Сохранение результатов в файл",
                    "Процесс сохранения результатов визуализации в файл", "Сохранение прошло успешно");
        }
    }
}
