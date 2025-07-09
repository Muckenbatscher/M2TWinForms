using M2TWinForms.Native;
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
            m2tDataGridView1.Rows.Add("Row 1", "Data 1", "button1", true);
            m2tDataGridView1.Rows.Add("Row 2", "Data 2", "button2", false);
            m2tDataGridView1.Rows.Add("Row 3", "Data 3", "button3", false);

            dataGridView1.Rows.Add("Row 4", "button4");
            dataGridView1.Rows.Add("Row 5", "button5");
        }

        private void m2tDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            M2TDataGridView dataGridView = sender as M2TDataGridView;
            var column = dataGridView.Columns[e.ColumnIndex];
        }

        private void m2tButton16_Click(object sender, EventArgs e)
        {
            M2TMessageBox.Show(TB_MessageText.Text, "None", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void m2tButton17_Click(object sender, EventArgs e)
        {
            M2TMessageBox.Show(TB_MessageText.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void m2tButton20_Click(object sender, EventArgs e)
        {
            M2TMessageBox.Show(TB_MessageText.Text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void m2tButton18_Click(object sender, EventArgs e)
        {
            M2TMessageBox.Show(TB_MessageText.Text, "Warning", MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Warning);
        }

        private void m2tButton19_Click(object sender, EventArgs e)
        {
            M2TMessageBox.Show(TB_MessageText.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
