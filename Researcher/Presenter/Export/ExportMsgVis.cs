using Model.CatRef;
using Researcher.Shared.Messages.VisOptimMsgs;
using Researcher.View.InterfaceElements;
using VisualizationMatlab;

namespace Researcher.Presenter.Export
{
    public readonly struct ExportMsgVis
    {
        public Form_Presenter_Vis_Msg FormMsg { get; init; }

        public VisMsg VisMsg { get; init; }

        public ValuesTable? ValuesTable { get; init; }

        public MatlabMathModel MathModel { get; init; }

        public bool Plot2D { get; init; }

        public bool Plot3D { get; init; }

        public bool ModelDesc { get; init; }

        public string FilePath { get; init; }
    }
}
