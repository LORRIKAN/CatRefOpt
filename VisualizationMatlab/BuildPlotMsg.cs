using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatlab
{
    public readonly struct BuildPlotMsg
    {
        public VisMsg VisMsg { get; init; }

        public bool Is3D { get; init; }
    }
}
