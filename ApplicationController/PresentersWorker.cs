using Model.Users;
using MVP;

namespace ApplicationController
{
    public class PresentersWorker
    {
        private IRoleBasedPresenter[] RoleBasedPresenters { get; set; }

        public ILoginPresenter LoginPresenter { get; }

        public PresentersWorker(ILoginPresenter loginPresenter,
            params IRoleBasedPresenter[] presenters)
        {
            LoginPresenter = loginPresenter;

            RoleBasedPresenters = presenters;
        }

        public IRoleBasedPresenter? GetPresenter(User user)
        {
            return RoleBasedPresenters.FirstOrDefault(p => p.Role.Name == user.Role.Name);
        }
    }
}