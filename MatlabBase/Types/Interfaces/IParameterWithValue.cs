using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatlabBase.Types.Interfaces
{
    public interface IParameterWithValue : IParameter
    {
        public double Value { get; set; }
    }
}
