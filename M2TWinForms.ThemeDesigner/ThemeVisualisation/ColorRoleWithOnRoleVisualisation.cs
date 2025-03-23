using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.ThemeDesigner.ThemeVisualisation
{
    public partial class ColorRoleWithOnRoleVisualisation : UserControl
    {
        public Color Color
        {
            get => CRV_ColorRole.Color;
            set
            {
                CRV_ColorRole.Color = value;
                CRV_OnColorRole.TextColor = value;
            }
        }
        public Color OnColor
        {
            get => CRV_OnColorRole.Color;
            set
            {
                CRV_OnColorRole.Color = value;
                CRV_ColorRole.TextColor = value;
            }
        }

        public string ColorRoleName
        {
            get => CRV_ColorRole.ColorRoleName;
            set
            {
                CRV_ColorRole.ColorRoleName = value;
                CRV_OnColorRole.ColorRoleName = "On " + value;
            }
        }

        public ColorRoleWithOnRoleVisualisation(Color color, Color onColor, string colorRoleName) : this()
        {
            ColorRoleName = colorRoleName;
            Color = color;
            OnColor = onColor;
        }

        public ColorRoleWithOnRoleVisualisation() : base()
        {
            InitializeComponent();
        }
    }
}
