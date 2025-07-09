using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms
{
    public class M2TDataGridViewCellStyle : DataGridViewCellStyle, IThemedControl
    {
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color SelectionForeColor
        {
            get => base.SelectionForeColor;
            set => base.SelectionForeColor = value;
        }
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color SelectionBackColor
        {
            get => base.SelectionBackColor;
            set => base.SelectionBackColor = value;
        }


        [Description("The Material Design Color Role used to determine background and text of the CellStyle")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Surface)]
        public M2TDataGridViewCellStyleColorRoleSelection ColorRole
        {
            get => _colorRole;
            set
            {
                _colorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TDataGridViewCellStyleColorRoleSelection _colorRole = M2TDataGridViewCellStyleColorRoleSelection.Surface;

        [Description("The Material Design Color Role used to determine background and text of the CellStyle when selected")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Primary)]
        public M2TDataGridViewCellStyleColorRoleSelection SelectionColorRole
        {
            get => _selectionColorRole;
            set
            {
                _selectionColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TDataGridViewCellStyleColorRoleSelection _selectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Primary;


        public M2TDataGridViewCellStyle() : base()
        {
            ApplyCurrentLoadedTheme();
        }
        public M2TDataGridViewCellStyle(DataGridViewCellStyle dataGridViewCellStyle) : base(dataGridViewCellStyle)
        {
            ApplyCurrentLoadedTheme();
        }
        public M2TDataGridViewCellStyle(M2TDataGridViewCellStyle dataGridViewCellStyle) : base(dataGridViewCellStyle)
        {
            ColorRole = dataGridViewCellStyle.ColorRole;
            SelectionColorRole = dataGridViewCellStyle.SelectionColorRole;
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            if (ColorRole != M2TDataGridViewCellStyleColorRoleSelection.Empty)
            {
                var foreColorRole = GetForegroundColorRole(ColorRole);
                this.ForeColor = CurrentLoadedThemeManager.GetColorForRole(foreColorRole);
                var backColorRole = GetBackgroundColorRole(ColorRole);
                this.BackColor = CurrentLoadedThemeManager.GetColorForRole(backColorRole);
            }
            else
            {
                this.ForeColor = Color.Empty;
                this.BackColor = Color.Empty;
            }
            if (SelectionColorRole != M2TDataGridViewCellStyleColorRoleSelection.Empty)
            {
                var selectionForeColorRole = GetForegroundColorRole(SelectionColorRole);
                this.SelectionForeColor = CurrentLoadedThemeManager.GetColorForRole(selectionForeColorRole);
                var selectionBackColorRole = GetBackgroundColorRole(SelectionColorRole);
                this.SelectionBackColor = CurrentLoadedThemeManager.GetColorForRole(selectionBackColorRole);
            }
            else
            {
                this.SelectionForeColor = Color.Empty;
                this.SelectionBackColor = Color.Empty;
            }
        }


        private static ColorRoles GetForegroundColorRole(M2TDataGridViewCellStyleColorRoleSelection colorRole)
        {
            return colorRole switch
            {
                M2TDataGridViewCellStyleColorRoleSelection.Primary => ColorRoles.OnPrimary,
                M2TDataGridViewCellStyleColorRoleSelection.PrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TDataGridViewCellStyleColorRoleSelection.Secondary => ColorRoles.OnSecondary,
                M2TDataGridViewCellStyleColorRoleSelection.SecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TDataGridViewCellStyleColorRoleSelection.Tertiary => ColorRoles.OnTertiary,
                M2TDataGridViewCellStyleColorRoleSelection.TertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TDataGridViewCellStyleColorRoleSelection.Error => ColorRoles.OnError,
                M2TDataGridViewCellStyleColorRoleSelection.ErrorContainer => ColorRoles.OnErrorContainer,
                M2TDataGridViewCellStyleColorRoleSelection.Surface => ColorRoles.OnSurface,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainer => ColorRoles.OnSurface,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerLowest => ColorRoles.OnSurface,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerLow => ColorRoles.OnSurface,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHigh => ColorRoles.OnSurface,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHighest => ColorRoles.OnSurface,
                _ => throw new ArgumentException($"Unknown {nameof(M2TDataGridViewCellStyleColorRoleSelection)} value: {colorRole}"),
            };
        }
        private static ColorRoles GetBackgroundColorRole(M2TDataGridViewCellStyleColorRoleSelection colorRole)
        {
            return colorRole switch
            {
                M2TDataGridViewCellStyleColorRoleSelection.Primary => ColorRoles.Primary,
                M2TDataGridViewCellStyleColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TDataGridViewCellStyleColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TDataGridViewCellStyleColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TDataGridViewCellStyleColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TDataGridViewCellStyleColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TDataGridViewCellStyleColorRoleSelection.Error => ColorRoles.Error,
                M2TDataGridViewCellStyleColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TDataGridViewCellStyleColorRoleSelection.Surface => ColorRoles.Surface,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new ArgumentException($"Unknown {nameof(M2TDataGridViewCellStyleColorRoleSelection)} value: {colorRole}"),
            };
        }
    }
}
