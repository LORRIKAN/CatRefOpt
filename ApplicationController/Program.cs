using Autofac;
using Model.Users;
using MVP;
using MatlabBase;
using WinFormsShared;

namespace ApplicationController
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            bool reloginRequired;

            do
            {
                using ILifetimeScope scope = ContainerConfig.Configure().BeginLifetimeScope();

                PresentersWorker presentersGetter = scope.Resolve<PresentersWorker>();

                User? loggedUser = presentersGetter.LoginPresenter.Run();

                if (loggedUser is null)
                    break;

                IRoleBasedPresenter? nextPresenter = presentersGetter.GetPresenter(loggedUser);

                if (nextPresenter is null)
                {
                    MessageDialog.ShowMessage(MessageType.Error, null, "Вход", "Попытка входа неудачна",
                        "В программе нет интерфейса для роли с таким наименованием");
                    break;
                }

                reloginRequired = nextPresenter.Run();
            } while (reloginRequired is true);

            MatlabGetter.TryCloseMatlab();
        }
    }
}