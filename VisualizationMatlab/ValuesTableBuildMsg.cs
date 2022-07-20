using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationMatlab
{
    public readonly struct ValuesTableBuildMsg
    {
        public VisMsg VisMsg { get; init; }

        public int N { get; init; }

        public int M { get; init; }
    }
}
