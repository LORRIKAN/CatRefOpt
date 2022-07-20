using Model.CatRef;
using Researcher.Shared.Messages.VisOptimMsgs;
using Researcher.View.InterfaceElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Researcher.Shared.Messages.ExportMsgs
{
    public readonly struct Form_Presenter_SaveVisResults_Msg
    {
        public OptionalItemsToSaveVis OptionalItemsToSave { get; init; }

        public Form_Presenter_Vis_Msg VisMsg { get; init; }

        public ValuesTable ValuesTable { get; init; }

        public string FilePath { get; init; }
    }
}
