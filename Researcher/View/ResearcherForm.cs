using Model.CatRef;
using Researcher.Shared;
using Researcher.View.InterfaceElements;
using Researcher.View.InterfaceElements.ParamsIO;
using WinFormsShared;
using MVP;
using Researcher.Shared.Messages.VisOptimMsgs;
using Researcher.Shared.Messages.ExportMsgs;

namespace Researcher.View
{
    public partial class ResearcherForm : Form, IView
    {
        public ResearcherForm()
        {
            InitializeComponent();
            reloginButt.Click += (_, _) => { ReloginRequired = true; Close(); };
            exitButt.Click += (_, _) => Close();
        }

        public bool ReloginRequired { get; private set; }
    }
}
