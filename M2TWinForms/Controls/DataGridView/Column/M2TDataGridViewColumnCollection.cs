using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public class M2TDataGridViewColumnCollection : DataGridViewColumnCollection
    {
        public M2TDataGridViewColumnCollection(M2TDataGridView owner) : base(owner) { }

        public override int Add(DataGridViewColumn dataGridViewColumn)
        {
            if (dataGridViewColumn is M2TDataGridViewColumn myColumn)
                return Add(myColumn);
            else
                throw new ArgumentException("Only MyDataGridViewColumn or derived types can be added to this collection.", nameof(dataGridViewColumn));
        }
        public int Add(M2TDataGridViewColumn column)
            => base.Add(column);


        public override void Insert(int columnIndex, DataGridViewColumn dataGridViewColumn)
        {
            if (dataGridViewColumn is M2TDataGridViewColumn myColumn)
                Insert(columnIndex, myColumn);
            else
                throw new ArgumentException("Only MyDataGridViewColumn or derived types can be inserted into this collection.", nameof(dataGridViewColumn));
        }
        public void Insert(int columnIndex, M2TDataGridViewColumn column)
            => base.Insert(columnIndex, column);


        public new M2TDataGridViewColumn this[int index]
        {
            get => (M2TDataGridViewColumn)base[index];
        }
        public new M2TDataGridViewColumn this[string columnName]
        {
            get => (M2TDataGridViewColumn)base[columnName];
        }
    }
}
