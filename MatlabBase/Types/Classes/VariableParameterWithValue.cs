using MatlabBase.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatlabBase.Types.Classes
{
    public class VariableParameterWithValue : ParameterWithValue, IVariableParameterWithValue
    {
        public double LowerBound { get; set; }
        public double UpperBound { get; set; }
    }
}
