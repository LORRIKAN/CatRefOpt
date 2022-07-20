using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatlab
{
    public readonly struct Build3DPathMsg
    {
        public VisMsg VisMsg { get; init; }

        public double[] X { get; init; }

        public double[] Y { get; init; }

        public double[] Z { get; init; }

        public string OptimMethodName { get; init; }
    }
}
