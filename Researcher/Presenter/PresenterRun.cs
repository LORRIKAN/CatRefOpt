using Model.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsShared;

namespace Researcher.Presenter
{
    public partial class ResearcherPresenter
    {

        public override bool Run()
        {
            if (!TryOpenMatlab())
                return true;

            return base.Run();
        }

        private bool TryOpenMatlab()
        {
            bool error = false;

            async IAsyncEnumerable<(string message, bool error, bool cancelable)> TrySetMatlab()
            {
                yield return ("Идёт открытие MATLAB...", false, false);
                var task = Task.Run(() => MatlabBase.MatlabGetter.Matlab);
                MLApp.MLApp? matlab = await task;
                if (matlab is null || task.IsFaulted)
                {
                    yield return ("Не удалось открыть экземпляр MATLAB. " +
                    "Возможно, на вашем компьютере не установлена требуемая версия пакета. " +
                    "Сейчас вы будете перенаправлены на окно входа в программу.", true, false);
                    error = true;
                }
            }

            MessageDialog.ShowMarqueeAwaitDialog(TrySetMatlab, null, "Открытие Matlab",
                "Процесс открытия MATLAB", aboveAll: true);

            return !error;
        }
    }
}
