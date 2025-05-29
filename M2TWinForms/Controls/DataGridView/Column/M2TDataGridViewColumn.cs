using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public class M2TDataGridViewColumn : DataGridViewColumn
    {
        [Category("My Custom Properties")]
        [Description("Dies ist eine benutzerdefinierte Eigenschaft für MyDataGridViewColumn.")]
        public string CustomColumnProperty { get; set; }

        [Category("My Custom Properties")]
        [Description("Gibt an, ob diese Spalte aktiv ist.")]
        public bool IsActive { get; set; }

        public M2TDataGridViewColumn()
        {
            CellTemplate = new DataGridViewTextBoxCell();
        }
        public M2TDataGridViewColumn(DataGridViewCell cellTemplate) : base(cellTemplate)
        {
        }

        public override object Clone()
        {
            M2TDataGridViewColumn clone = (M2TDataGridViewColumn)base.Clone();
            clone.CustomColumnProperty = this.CustomColumnProperty;
            clone.IsActive = this.IsActive;
            return clone;
        }
    }
}
