using Researcher.View.InterfaceElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Researcher.Shared.Messages.ExportMsgs
{
    public readonly struct Form_Presenter_SaveOptimResults_Msg
    {
        public OptionalItemsToSaveOptim OptionalItemsToSave { get; init; }

        public DataGridView TableOfPath { get; init; }

        public string FilePath { get; init; }
    }
}
