using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public class M2TDataGridViewTextBoxColumn : M2TDataGridViewColumn
    {
        public M2TDataGridViewTextBoxColumn() : base(new DataGridViewTextBoxCell())
        {
        }
    }
}
