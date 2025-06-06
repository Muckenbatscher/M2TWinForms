using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.Demo
{
    public partial class Form1 : M2TForm
    {
        public Form1()
        {
            InitializeComponent();
            m2tDataGridView1.Rows.Add("Row 1", "Data 1");
            m2tDataGridView1.Rows.Add("Row 2", "Data 2");
            m2tDataGridView1.Rows.Add("Row 3", "Data 3");
        }
    }
}
