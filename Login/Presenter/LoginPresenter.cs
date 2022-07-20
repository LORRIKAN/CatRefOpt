using Login.View;
using Model.Users;
using MVP;
using Repository;

namespace Login.Presenter
{
    public class LoginPresenter : ILoginPresenter
    {
        private LoginForm LoginForm { get; set; }

        private CatRefUsersDbContext UsersContext { get; set; }

        private User? LoggedUser { get; set; } = null;

        public LoginPresenter(LoginForm loginForm, CatRefUsersDbContext usersContext)
        {
            LoginForm = loginForm;
            LoginForm.LoginAttempt += LoginForm_LoginAttempt;

            UsersContext = usersContext;
        }

        private string? LoginForm_LoginAttempt(string login, string password)
        {
            User? foundUser = UsersContext.Users.FirstOrDefault(u => u.Name == login && u.Password == password);

            if (foundUser is not null)
            {
                LoggedUser = foundUser;

                return null;
            }
            else
                return "Неправильный логин/пароль";
        }

        public User? Run()
        {
            Application.Run(LoginForm);

            return LoggedUser;
        }
    }
}