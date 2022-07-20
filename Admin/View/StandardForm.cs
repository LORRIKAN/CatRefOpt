namespace Admin.View
{
    public partial class StandardForm : Form, IFormWithTableEditor
    {
        public StandardTableEditor TableEditor => standardTableEditor;

        public StandardForm()
        {
            InitializeComponent();
        }
    }
}