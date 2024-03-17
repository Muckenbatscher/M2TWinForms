using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Models.Serialization
{
    internal class SerializedTheme
    {
        public string Name { get; set; }
        public IEnumerable<SerializedColorUsage> Colors { get; set; }
    }
}
