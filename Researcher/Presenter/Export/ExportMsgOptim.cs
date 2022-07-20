using OptimizationMatlab;
using Researcher.Shared.Messages.VisOptimMsgs;
using VisualizationMatlab;

namespace Researcher.Presenter.Export
{
    public readonly struct ExportMsgOptim
    {
        public Form_Presenter_Optim_Msg FormMsg { get; init; }

        public Presenter_Form_Optim_Msg PresMsg { get; init; }

        public DataGridView? TableOfPath { get; init; }

        public Build2DPathMsg? Path2DMsg { get; init; }

        public Build3DPathMsg? Path3DMsg { get; init; }

        public bool ModelDesc { get; init; }

        public bool OptimMethodDesc { get; init; }

        public string FilePath { get; init; }
    }
}
