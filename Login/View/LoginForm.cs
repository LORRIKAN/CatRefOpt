using WinFormsShared;

namespace Login.View
{
    public delegate string? LoginAttempt(string login, string password);

    public partial class LoginForm : Form
    {
        public event LoginAttempt? LoginAttempt;

        public LoginForm()
        {
            InitializeComponent();
        }

        private async void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender is not TextBox)
                return;

            if (e.KeyCode == Keys.Enter)
            {
                await CheckTextBoxes_AndTryToLogin();
            }
        }

        private async Task CheckTextBoxes_AndTryToLogin()
        {
            if (!string.IsNullOrEmpty(loginTextBox.Text) && !string.IsNullOrWhiteSpace(loginTextBox.Text) &&
                !string.IsNullOrEmpty(passwordTextBox.Text) && !string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                loginTextBox.Enabled = false;
                passwordTextBox.Enabled = false;
                loginButt.Enabled = false;

                Task<string?> loginTask = Task.Run(() =>
                    LoginAttempt is not null ?
                    LoginAttempt(loginTextBox.Text, passwordTextBox.Text)
                    : "Попытка входа не была совершена. Проблема в программном коде.");

                async IAsyncEnumerable<(string msg, bool error, bool cancelable)> LoginReportFunc()
                {
                    yield return ("Выполняется вход в систему...", false, false);
                    string? loginResult = await loginTask;
                    yield break;
                }

                MessageDialog.ShowMarqueeAwaitDialog(LoginReportFunc, this, "Процесс входа в систему",
                    aboveAll: true);

                string? errorMessage = await loginTask;

                if (errorMessage is not null)
                {
                    MessageDialog.ShowMessage(MessageType.Error, this, "Процесс входа в систему",
                        "Вход не удался", errorMessage);

                    loginTextBox.Enabled = true;
                    passwordTextBox.Enabled = true;
                    loginButt.Enabled = true;
                }
                else
                    Close();
            }
        }

        private async void LoginButt_Click(object sender, EventArgs e)
        {
            if (sender is not Button)
                return;

            await CheckTextBoxes_AndTryToLogin();
        }
    }
}
