namespace Researcher.View.InterfaceElements
{
    public partial class OptimResultsSaveForm : Form
    {
        public OptimResultsSaveForm()
        {
            InitializeComponent();
            essentialElems.SetItemChecked(0, true);
            essentialElems.SetItemChecked(1, true);
            essentialElems.SetItemChecked(2, true);
            essentialElems.SetItemChecked(3, true);
            essentialElems.SetItemChecked(4, true);
            essentialElems.SetItemChecked(5, true);
            essentialElems.SetItemChecked(6, true);
        }

        public OptionalItemsToSaveOptim? Run(bool canBuildPathPlots)
        {
            if (canBuildPathPlots)
            {
                optionalElems.Items.AddRange(new[]
                {
                    "Путь решения на графике линий равных значений целевой функции",
                    "Путь решения на графике поверхности отклика целевой функции"
                });
            }
            ShowDialog();
            if (Cancel)
                return null;
            else
                return new OptionalItemsToSaveOptim
                {
                    MathModelDesc = optionalElems.GetItemChecked(0),
                    OptimMethodDesc = optionalElems.GetItemChecked(1),
                    PathTable = optionalElems.GetItemChecked(2),
                    Path2DPlot = canBuildPathPlots && optionalElems.GetItemChecked(3),
                    Path3DPlot = canBuildPathPlots && optionalElems.GetItemChecked(4),
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

    public readonly struct OptionalItemsToSaveOptim
    {
        public bool MathModelDesc { get; init; }

        public bool OptimMethodDesc { get; init; }

        public bool PathTable { get; init; }

        public bool Path2DPlot { get; init; }

        public bool Path3DPlot { get; init; }
    }
}
