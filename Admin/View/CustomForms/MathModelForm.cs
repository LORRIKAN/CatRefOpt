using Model.CatRef;
using WinFormsShared;

namespace Admin.View.CustomForms
{
    public partial class MathModelForm : Form, IFormWithTableEditor
    {
        public StandardTableEditor TableEditor => standardTableEditor;

        public MathModelForm()
        {
            InitializeComponent();
        }

        private void setDescriptionButt_Click(object sender, EventArgs e)
        {
            TableEditor.ExecuteEditAction(() =>
            {
                if ((standardTableEditor.dataGridView.DataSource as BindingSource)
                        ?.Current is not MatlabMathModel mathModel)
                {
                    MessageDialog.ShowMessage(MessageType.Error, this,
                        text: "Сначала выберите математическую модель");
                    return;
                }

                (bool canceled, string description) = new DescriptionSetForm().Run(
                    mathModel.Description ?? string.Empty);

                if (!canceled)
                    mathModel.Description = description;
            });
        }
    }
}
