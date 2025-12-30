using M2TWinForms.Controls.Window;

namespace M2TWinForms.Demo
{
    public partial class Form2 : M2TFormNative
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void m2tButton1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
        }

        private void m2tButton2_Click(object sender, EventArgs e)
        {
            var form = new Form2();
            form.ShowDialog();
        }
    }
}
