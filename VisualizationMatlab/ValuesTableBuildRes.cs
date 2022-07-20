using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatlab
{
    public readonly struct ValuesTableBuildRes
    {
        public double XDelta { get; init; }

        public double YDelta { get; init; }

        public double[,] FuncValues { get; init; }

        public string? ErrorMsg { get; init; }
    }
}
