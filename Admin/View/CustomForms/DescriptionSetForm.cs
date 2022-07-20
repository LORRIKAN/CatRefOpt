namespace Admin.View.CustomForms
{
    public partial class DescriptionSetForm : Form
    {
        public DescriptionSetForm()
        {
            InitializeComponent();
        }

        private bool Canceled { get; set; }

        public (bool canceled, string description) Run(string existingDescription)
        {
            richTextBox.Text = existingDescription;
            ShowDialog();
            return (Canceled, richTextBox.Text);
        }

        private void okButt_Click(object sender, EventArgs e)
        {
            Close();
            Canceled = false;
        }

        private void cancelButt_Click(object sender, EventArgs e)
        {
            Close();
            Canceled = true;
        }
    }
}
