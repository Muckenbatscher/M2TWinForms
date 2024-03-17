using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Models
{
    public class Theme
    {
        public string Name { get; set; }
        public IEnumerable<ColorUsage> Colors { get; set; }
    }
}
