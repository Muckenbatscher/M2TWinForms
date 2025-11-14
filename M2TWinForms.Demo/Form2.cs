using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.Demo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            var captionColor = CurrentLoadedThemeManager.GetColorForRole(ColorRoles.SurfaceContainerHigh);
            FormCaptionBackColor = captionColor;
            var titleTextColor = CurrentLoadedThemeManager.GetColorForRole(ColorRoles.OnSurface);
            FormCaptionTextColor = titleTextColor;

            var backcolor = CurrentLoadedThemeManager.GetColorForRole(ColorRoles.Surface);
            BackColor = backcolor;
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            var borderColor = CurrentLoadedThemeManager.GetColorForRole(ColorRoles.Primary);
            FormBorderColor = borderColor;
        }
        private void Form2_Deactivate(object sender, EventArgs e)
        {
            var borderColor = CurrentLoadedThemeManager.GetColorForRole(ColorRoles.SurfaceContainerHigh);
            FormBorderColor = borderColor;
        }

        private void m2tButton1_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.ShowDialog();
        }
    }
}
