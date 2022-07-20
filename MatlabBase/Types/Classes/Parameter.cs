using MatlabBase.Types.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatlabBase.Types.Classes
{
    public class Parameter : IParameter
    {
        public string Designation { get; set; } = string.Empty;
        public string MeasureUnit { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
