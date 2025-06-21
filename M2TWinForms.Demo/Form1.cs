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
