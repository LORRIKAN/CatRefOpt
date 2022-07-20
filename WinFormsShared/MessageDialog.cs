namespace WinFormsShared
{
    public static class MessageDialog
    {
        private static void SetStringArg(ref string? arg, string? value)
        {
            if (string.IsNullOrEmpty(arg))
                arg = value;
        }

        private static TaskDialogButton ShowDialog(Form? window, TaskDialogPage page)
        {
            if (window is null)
            {
                var moq = new MoqForm(page);
                Application.Run(moq);

                return moq.Result;
            }

            return TaskDialog.ShowDialog(window, page);
        }

        private static TaskDialogPage CreatePage(bool aboveAll, string? caption, string? heading, string? text, TaskDialogButtonCollection buttons)
        {
            return new TaskDialogPage
            {
                AllowCancel = !aboveAll,
                AllowMinimize = !aboveAll,
                Buttons = buttons,
                Caption = caption,
                Heading = heading,
                Text = text,
                Icon = TaskDialogIcon.Information
            };
        }

        public static TaskDialogButton ShowMessage(MessageType messageType, Form? window,
            string? caption = null, string? heading = null, string? text = null,
            bool setStringArgsAccordingToMessageType = false, bool aboveAll = false)
        {
            void SetStringArgs(string captionVal, string headingVal, string textVal)
            {
                if (setStringArgsAccordingToMessageType)
                {
                    SetStringArg(ref caption, captionVal);
                    SetStringArg(ref heading, headingVal);
                    SetStringArg(ref text, textVal);
                }
            }

            TaskDialogButtonCollection buttons;
            TaskDialogIcon icon;

            switch (messageType)
            {
                case MessageType.Success:
                    buttons = new TaskDialogButtonCollection { TaskDialogButton.OK };
                    SetStringArgs("Результат", "Результат операции",
                        "Операция выполнена успешно");
                    icon = TaskDialogIcon.ShieldSuccessGreenBar;
                    break;
                case MessageType.Error:
                    buttons = new TaskDialogButtonCollection { TaskDialogButton.Close };
                    SetStringArgs("Результат", "Результат операции",
                        "Операция не была выполнена");
                    icon = TaskDialogIcon.ShieldErrorRedBar;
                    break;
                case MessageType.YesNo:
                    buttons = new TaskDialogButtonCollection { TaskDialogButton.Yes, TaskDialogButton.No };
                    SetStringArgs("Выберите действие", "Выберите дальнейшее действие",
                        string.Empty);
                    icon = TaskDialogIcon.Information;
                    break;
                case MessageType.YesNoCancel:
                    buttons = new TaskDialogButtonCollection { TaskDialogButton.Yes, TaskDialogButton.No,
                        TaskDialogButton.Cancel};
                    SetStringArgs("Выберите действие", "Выберите дальнейшее действие",
                        string.Empty);
                    icon = TaskDialogIcon.Information;
                    break;
                default:
                    buttons = new TaskDialogButtonCollection { TaskDialogButton.Close };
                    icon = TaskDialogIcon.None;
                    break;
            }

            var page = CreatePage(aboveAll, caption, heading, text, buttons);

            page.Icon = icon;

            return ShowDialog(window, page);
        }

        public static void ShowInformationMessage(Form? window, string text, string? caption = null,
            string? heading = null, bool setStringArgsAccordingToMessageType = false,
            bool aboveAll = false)
        {
            if (setStringArgsAccordingToMessageType)
                SetStringArg(ref caption, "Информация");

            TaskDialogPage page = CreatePage(aboveAll, caption, heading, text,
                new TaskDialogButtonCollection { TaskDialogButton.OK });

            ShowDialog(window, page);
        }

        public static TaskDialogButton ShowMarqueeAwaitDialog(
            Func<IAsyncEnumerable<(string message, bool error, bool cancelable)>> progressFunc,
            Form? window, string? caption = null, string? heading = null,
            bool setStringArgsAccordingToMessageType = false, bool aboveAll = false)
        {
            if (setStringArgsAccordingToMessageType)
            {
                SetStringArg(ref caption, "Окно прогресса");
            }

            TaskDialogButton okButt = TaskDialogButton.OK;
            TaskDialogButton cancelButt = TaskDialogButton.Cancel;
            okButt.Visible = false;
            var buttons = new TaskDialogButtonCollection { cancelButt, okButt };

            TaskDialogPage page = CreatePage(aboveAll, caption, heading, null, buttons);

            page.ProgressBar = new TaskDialogProgressBar { State = TaskDialogProgressBarState.Marquee };
            bool err = false;
            string? errorMsg = null;
            page.Created += async (_, _) =>
            {
                await foreach ((string message, bool error, bool cancelable) in progressFunc())
                {
                    page.Text = message;
                    err = error;
                    if (error)
                    {
                        err = error;
                        errorMsg = message;
                        break;
                    }

                    cancelButt.Enabled = cancelable;
                }

                okButt.PerformClick();
            };

            var result = ShowDialog(window, page);
            if (err)
                return ShowMessage(MessageType.Error, window, caption, heading, errorMsg, setStringArgsAccordingToMessageType, aboveAll);

            return result;
        }

        public static TaskDialogButton ShowNormalAwaitDialog(
            Func<IAsyncEnumerable<(int progressVal, string? progressStr, bool error, bool cancelable)>>
            progressFunc, int min, int max, Form? window, string? caption = null, string? heading = null,
            bool setStringArgsAccordingToMessageType = false, bool aboveAll = false)
        {
            if (setStringArgsAccordingToMessageType)
            {
                SetStringArg(ref caption, "Окно прогресса");
            }

            TaskDialogButton okButt = TaskDialogButton.OK;
            TaskDialogButton cancelButt = TaskDialogButton.Cancel;
            okButt.Visible = false;
            var buttons = new TaskDialogButtonCollection { cancelButt, okButt };

            TaskDialogPage page = CreatePage(aboveAll, caption, heading, null, buttons);

            page.ProgressBar = new TaskDialogProgressBar
            {
                State = TaskDialogProgressBarState.Normal,
                Minimum = min,
                Maximum = max,
                Value = min
            };
            bool err = false;
            string? errorMsg = null;
            page.Created += async (_, _) =>
            {
                bool err = false;
                await foreach ((int progressVal, string? progressStr, bool error, bool cancelable) in progressFunc())
                {
                    page.Text = progressStr;
                    page.ProgressBar.Value = progressVal;
                    if (error)
                    {
                        err = error;
                        errorMsg = progressStr;
                        break;
                    }

                    cancelButt.Enabled = cancelable;
                }

                okButt.PerformClick();
            };
            var result = ShowDialog(window, page);
            if (err)
                return ShowMessage(MessageType.Error, window, caption, heading, errorMsg, setStringArgsAccordingToMessageType, aboveAll);

            return result;
        }
    }

    public enum MessageType
    {
        Success,
        Error,
        YesNo,
        YesNoCancel
    }
}