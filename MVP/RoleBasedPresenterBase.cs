using Model.Users;

namespace MVP
{
    public abstract class RoleBasedPresenterBase<T> : IRoleBasedPresenter where T : Form, IView
    {
        public RoleBasedPresenterBase(Role role, T form)
        {
            Role = role;
            Form = form;
        }

        public Role Role { get; set; }

        protected virtual void BeforeRelogin() { }

        protected virtual void BeforeClose() { }

        protected T Form { get; }

        public virtual bool Run()
        {
            Application.Run(Form);

            if (Form.ReloginRequired is true)
                BeforeRelogin();
            else
                BeforeClose();

            return Form.ReloginRequired;
        }
    }
}