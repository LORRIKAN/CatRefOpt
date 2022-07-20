using Model.CatRef;
using WinFormsShared;

namespace Researcher.View.InterfaceElements
{
    public partial class DescriptionForm : Form
    {
        public DescriptionForm()
        {
            InitializeComponent();
        }

        public void Run(string name, string description)
        {
            Text = $"Описание \"{name}\"";
            richTextBox.Text = description;
            Show();
        }
    }
}
