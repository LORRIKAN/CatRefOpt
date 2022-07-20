namespace Researcher.View.InterfaceElements
{
    public partial class VisResultsSaveForm : Form
    {
        public VisResultsSaveForm()
        {
            InitializeComponent();
            essentialElems.SetItemChecked(0, true);
            essentialElems.SetItemChecked(1, true);
            essentialElems.SetItemChecked(2, true);
            essentialElems.SetItemChecked(3, true);
        }

        public OptionalItemsToSaveVis? Run(bool canBuildPlots, bool canBuildValuesTable)
        {
            if (canBuildPlots)
            {
                optionalElems.Items.AddRange(new[]
                {
                    "График линий равных значений функции",
                    "График поверхности отклика функции"
                });
            }
            if (canBuildValuesTable)
                optionalElems.Items.Add("Текущая таблица значений");
            ShowDialog();
            if (Cancel)
                return null;
            else
                return new OptionalItemsToSaveVis
                {
                    MathModelDesc = optionalElems.GetItemChecked(0),
                    Plot2D = canBuildPlots && optionalElems.GetItemChecked(1),
                    Plot3D = canBuildPlots && optionalElems.GetItemChecked(2),
                    TableOfValues = canBuildValuesTable && optionalElems
                        .GetItemChecked(canBuildPlots ? 3 : 1),
                };
        }

        private bool Cancel { get; set; } = true;

        private void okButt_Click(object sender, EventArgs e)
        {
            Cancel = false;
            Close();
        }

        private void abortButt_Click(object sender, EventArgs e)
        {
            Cancel = true;
            Close();
        }
    }

    public readonly struct OptionalItemsToSaveVis
    {
        public bool TableOfValues { get; init; }

        public bool Plot2D { get; init; }

        public bool Plot3D { get; init; }

        public bool MathModelDesc { get; init; }
    }
}
