using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatlabBase.Types.Interfaces
{
    public interface IParameter
    {
        string MeasureUnit { get; set; }

        string Name { get; set; }

        string Designation { get; set; }
    }
}
