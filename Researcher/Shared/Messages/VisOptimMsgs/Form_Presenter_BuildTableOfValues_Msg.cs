using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Researcher.Shared.Messages.VisOptimMsgs
{
    public readonly struct Form_Presenter_BuildTableOfValues_Msg
    {
        public Form_Presenter_Vis_Msg VisMsg { get; init; }

        public int N { get; init; }

        public int M { get; init; }
    }
}
