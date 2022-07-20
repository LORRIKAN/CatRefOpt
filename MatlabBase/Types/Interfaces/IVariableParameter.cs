using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatlabBase.Types.Interfaces
{
    public interface IVariableParameter : IParameter
    {
        double LowerBound { get; set; }

        double UpperBound { get; set; }
    }
}
