using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    public partial class ColorRoleVisualisation: UserControl
    {
        public Color Color 
        { 
            get => BackColor;
            set => BackColor = value;
        }
        public Color TextColor
        {
            get => LB_ColorRoleName.ForeColor;
            set => LB_ColorRoleName.ForeColor = value;
        }
        public string ColorRoleName 
        { 
            get => LB_ColorRoleName.Text;
            set => LB_ColorRoleName.Text = value;
        }

        public ColorRoleVisualisation(Color color, Color textColor, string colorRoleName) : this()
        {
            ColorRoleName = colorRoleName;
            Color = color;
            TextColor = textColor;
        }
        public ColorRoleVisualisation() : base()
        {
            InitializeComponent();
            ColorRoleName = "Color Role";
            Color = Color.LightGray;
            TextColor = Color.Black;
        }
    }
}
