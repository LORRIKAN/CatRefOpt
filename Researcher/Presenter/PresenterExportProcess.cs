using Researcher.Presenter.Export;
using Researcher.Shared.Messages.ExportMsgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Researcher.Presenter
{
    public partial class ResearcherPresenter
    {
        private string? Form_SaveVisResults(Form_Presenter_SaveVisResults_Msg msg)
        {
            var plot2D = msg.OptionalItemsToSave.Plot2D;
            var plot3D = msg.OptionalItemsToSave.Plot3D;
            var tableOfValues = msg.OptionalItemsToSave.TableOfValues;

            var exportMsg = new ExportMsgVis
            {
                FilePath = msg.FilePath,
                FormMsg = msg.VisMsg,
                ModelDesc = msg.OptionalItemsToSave.MathModelDesc,
                Plot2D = plot2D,
                Plot3D = plot3D,
                ValuesTable = tableOfValues ? msg.ValuesTable : null,
                MathModel = msg.VisMsg.MathModel,
                VisMsg = GetMatlabVisMsg(msg.VisMsg)
            };

            return ExcelExporter.ExportVisResults(exportMsg);
        }

        private string? Form_SaveOptimResults(Form_Presenter_SaveOptimResults_Msg msg)
        {
            if (LastOptimRequest is null || LastOptimResult is null)
                return "Сначала проведите процесс оптимизации";
            var path2D = msg.OptionalItemsToSave.Path2DPlot;
            var path3D = msg.OptionalItemsToSave.Path3DPlot;
            var pathTable = msg.OptionalItemsToSave.PathTable;

            var exportMsg = new ExportMsgOptim
            {
                FilePath = msg.FilePath,
                FormMsg = LastOptimRequest.Value,
                ModelDesc = msg.OptionalItemsToSave.MathModelDesc,
                OptimMethodDesc = msg.OptionalItemsToSave.OptimMethodDesc,
                Path2DMsg = path2D ? GetMatlab2DPathMsg(LastOptimResult.Value, LastOptimRequest.Value) : null,
                Path3DMsg = path3D ? GetMatlab3DPathMsg(LastOptimResult.Value, LastOptimRequest.Value) : null,
                PresMsg = LastOptimResult.Value,
                TableOfPath = pathTable ? msg.TableOfPath : null
            };

            return ExcelExporter.ExportOptimResults(exportMsg);
        }
    }
}
