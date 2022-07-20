using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsShared
{
    internal class MoqForm : Form
    {
        public MoqForm(TaskDialogPage page)
        {
            Page = page;
            StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnShown(EventArgs e)
        {
            Visible = false;
            Result = TaskDialog.ShowDialog(this, Page);
            base.OnShown(e);
            Close();
        }

        private TaskDialogPage Page { get; set; }

        public TaskDialogButton Result { get; private set; } = null!;
    }
}
