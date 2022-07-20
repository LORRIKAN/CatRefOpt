using MatlabBase.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Researcher.Shared.Messages.VisOptimMsgs
{
    public readonly struct Presenter_Form_BuildTableOfValues_Msg
    {
        public double[,] FuncValues { get; init; }

        public double YDelta { get; init; }

        public double XDelta { get; init; }

        public IVariableParameter XParam { get; init; }

        public IVariableParameter YParam { get; init; }

        public string? ErrorMsg { get; init; }
    }
}
