using Model;
using Model.CatRef;
using Researcher.Shared;
using Researcher.View.InterfaceElements.ParamsIO.NumericsValidation;
using System.ComponentModel;

namespace Researcher.View.InterfaceElements
{
    public partial class ValuesTable : UserControl
    {
        public ValuesTable()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            YMult.ParseAndCheckConditions.CheckFuncs.Add((v) =>
            {
                if (tableBuildMessage.FuncValues is null)
                    return null;

                if ((tableBuildMessage.FuncValues.GetLength(0)) % (int)v is not 0)
                    return $"Значение должно быть делителем количества " +
                    $"строк ({tableBuildMessage.FuncValues.GetLength(0)}) нацело";

                return null;
            });
            XMult.ParseAndCheckConditions.CheckFuncs.Add((v) =>
            {
                if (tableBuildMessage.FuncValues is null)
                    return null;

                if ((tableBuildMessage.FuncValues.GetLength(1)) % (int)v is not 0)
                    return $"Значение должно быть делителем количества " +
                    $"столбцов ({tableBuildMessage.FuncValues.GetLength(1)}) нацело";

                return null;
            });

            YMultInput.Parameter = YMult;
            XMultInput.Parameter = XMult;

            buildTableButt.ValidatableContainerLogic.AddControlsRange(YMultInput, XMultInput);
            buildTableButt.Click += (_, _) => BuildTable();
        }
        static string MU(string? mu) => string.IsNullOrEmpty(mu) ? string.Empty : $", {mu}";

        private TableBuildMessage tableBuildMessage;

        [Browsable(false)]
        [ReadOnly(true)]
        public TableBuildMessage TableBuildMessage
        {
            get => tableBuildMessage;
            set
            {
                tableBuildMessage = value;
                yLbl.Text = $"{value.YParam.Name}{MU(value.YParam.MeasureUnit)} - по вертикали, с шагом {YDeltaXMult:F2}";
                xLbl.Text = $"{value.XParam.Name}{MU(value.XParam.MeasureUnit)} - по горизонтали, с шагом {XDeltaXMult:F2}";
                tableName.Text = $"Таблица значений \"{value.TargetFunc.Name}{MU(value.TargetFunc.MeasureUnit?.Designation)}\"";
                YMult.Value = 1;
                YMultInput.Value = "1";
                XMult.Value = 1;
                XMultInput.Value = "1";
                if (value.BuildOnInit is true)
                    BuildTable();
            }
        }

        public bool TableBuilt { get; private set; } = false;

        public string TableName => tableName.Text;

        public string YLbl => yLbl.Text;

        public string XLbl => xLbl.Text;

        private Parameter YMult { get; set; } = new()
        {
            DecimalPlaces = 0,
            Name = "Множитель шага по вертикали",
            ParameterType = ParameterType.InputEssential,
            Value = 1,
            ParseAndCheckConditions = new(IntParseAndCheckConditions.Parse, DoubleParseAndCheckConditions.MoreThanZero)
        };

        private Parameter XMult { get; set; } = new()
        {
            DecimalPlaces = 0,
            Name = "Множитель шага по горизонтали",
            ParameterType = ParameterType.InputEssential,
            Value = 1,
            ParseAndCheckConditions = new(IntParseAndCheckConditions.Parse, DoubleParseAndCheckConditions.MoreThanZero)
        };
        public DataGridView Data => dataGridView;

        public double YDeltaXMult => (YMult.Value ?? 1) * TableBuildMessage.YDelta;

        public double XDeltaXMult => (XMult.Value ?? 1) * TableBuildMessage.XDelta;

        private void BuildTable()
        {
            dataGridView.Columns.Clear();

            int HMult = (int)XMult.Value!;
            int VMult = (int)YMult.Value!;

            for (int j = 0; j < TableBuildMessage.FuncValues.GetLength(0); j += HMult)
            {
                dataGridView.Columns.Add(j.ToString(),
                    (TableBuildMessage.XParam.LowerBound + TableBuildMessage.XDelta * j)
                    .ToString("F2"));
            }

            for (int i = 0; i < TableBuildMessage.FuncValues.GetLength(1); i += VMult)
            {
                var row = new DataGridViewRow();
                row.HeaderCell.Value = (TableBuildMessage.YParam.LowerBound + TableBuildMessage.YDelta * i)
                    .ToString("F2");

                dataGridView.Rows.Add(row);
            }

            for (int j = 0; j < TableBuildMessage.FuncValues.GetLength(0); j += HMult)
                for (int i = 0; i < TableBuildMessage.FuncValues.GetLength(1); i += VMult)
                    dataGridView[j / HMult, i / VMult].Value =
                        TableBuildMessage.FuncValues[j,i]
                        .ToString($"F{TableBuildMessage.ValuesPrecision}");

            dataGridView.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            yLbl.Text = $"{TableBuildMessage.YParam.Name}" +
                $"{MU(TableBuildMessage.YParam.MeasureUnit)} - по вертикали, с шагом {YDeltaXMult:F2}";
            xLbl.Text = $"{TableBuildMessage.XParam.Name}" +
                $"{MU(TableBuildMessage.XParam.MeasureUnit)} - по горизонтали, с шагом {XDeltaXMult:F2}";
            TableBuilt = true;
        }
    }
}
