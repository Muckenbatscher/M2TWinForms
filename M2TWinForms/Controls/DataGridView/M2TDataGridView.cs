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
    public class M2TDataGridView : DataGridView, IThemedControl
    {
        [DefaultValue(false)]
        public new bool EnableHeadersVisualStyles
        {
            get => base.EnableHeadersVisualStyles;
            set => base.EnableHeadersVisualStyles = value;
        }
        [DefaultValue(DataGridViewHeaderBorderStyle.Single)]
        public new DataGridViewHeaderBorderStyle ColumnHeadersBorderStyle
        {
            get => base.ColumnHeadersBorderStyle;
            set => base.ColumnHeadersBorderStyle = value;
        }
        [DefaultValue(DataGridViewHeaderBorderStyle.Single)]
        public new DataGridViewHeaderBorderStyle RowHeadersBorderStyle
        {
            get => base.RowHeadersBorderStyle;
            set => base.RowHeadersBorderStyle = value;
        }

        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color BackgroundColor
        {
            get => base.BackgroundColor;
            set => base.BackgroundColor = value;
        }

        [Description("The Material Design Color Role used to determine background of the DataGridView")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewBackgroundColorSelection.SurfaceContainer)]
        public M2TDataGridViewBackgroundColorSelection BackgroundColorRole
        {
            get => _backgroundColorRole;
            set
            {
                _backgroundColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TDataGridViewBackgroundColorSelection _backgroundColorRole = M2TDataGridViewBackgroundColorSelection.SurfaceContainer;


        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color GridColor
        {
            get => base.GridColor;
            set => base.GridColor = value;
        }

        [Description("The Material Design Color Role used to determine background of the DataGridView")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewGridColorSelection.OnSurfaceVariant)]
        public M2TDataGridViewGridColorSelection GridColorRole
        {
            get => _gridColorRole;
            set
            {
                _gridColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TDataGridViewGridColorSelection _gridColorRole = M2TDataGridViewGridColorSelection.OnSurfaceVariant;

        public new M2TDataGridViewCellStyle DefaultCellStyle
        {
            get 
            {
                if (base.DefaultCellStyle is M2TDataGridViewCellStyle m2tStyle)
                    return m2tStyle;
                var newM2tStyle = new M2TDataGridViewCellStyle(base.DefaultCellStyle);
                base.DefaultCellStyle = newM2tStyle;
                return newM2tStyle;
            }
            set => base.DefaultCellStyle = value;
        }

        [Description("The Material Design Color Role used to determine background and text a cell")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Surface)]
        public M2TDataGridViewCellStyleColorRoleSelection DefaultCellStyleColorRole
        {
            get => DefaultCellStyle.ColorRole;
            set
            {
                DefaultCellStyle.ColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }

        [Description("The Material Design Color Role used to determine background and text of a cell when selected")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Primary)]
        public M2TDataGridViewCellStyleColorRoleSelection DefaultCellStyleSelectionColorRole
        {
            get => DefaultCellStyle.SelectionColorRole;
            set
            {
                DefaultCellStyle.SelectionColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }

        public new M2TDataGridViewCellStyle ColumnHeadersDefaultCellStyle
        {
            get
            {
                if (base.ColumnHeadersDefaultCellStyle is M2TDataGridViewCellStyle m2tStyle)
                    return m2tStyle;
                var newM2tStyle = new M2TDataGridViewCellStyle(base.ColumnHeadersDefaultCellStyle);
                base.ColumnHeadersDefaultCellStyle = newM2tStyle;
                return newM2tStyle;
            }
            set => base.ColumnHeadersDefaultCellStyle = value;
        }
        [Description("The Material Design Color Role used to determine background and text of the column header")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHigh)]
        public M2TDataGridViewCellStyleColorRoleSelection ColumnHeadersDefaultCellStyleColorRole
        {
            get => ColumnHeadersDefaultCellStyle.ColorRole;
            set
            {
                ColumnHeadersDefaultCellStyle.ColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }

        [Description("The Material Design Color Role used to determine background and text of the column header when selected")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Primary)]
        public M2TDataGridViewCellStyleColorRoleSelection ColumnHeadersDefaultCellStyleSelectionColorRole
        {
            get => ColumnHeadersDefaultCellStyle.SelectionColorRole;
            set
            {
                ColumnHeadersDefaultCellStyle.SelectionColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }


        public new M2TDataGridViewCellStyle RowHeadersDefaultCellStyle
        {
            get
            {
                if (base.RowHeadersDefaultCellStyle is M2TDataGridViewCellStyle m2tStyle)
                    return m2tStyle;
                var newM2tStyle = new M2TDataGridViewCellStyle(base.RowHeadersDefaultCellStyle);
                base.RowHeadersDefaultCellStyle = newM2tStyle;
                return newM2tStyle;
            }
            set => base.RowHeadersDefaultCellStyle = value;
        }
        [Description("The Material Design Color Role used to determine background and text of the CellStyle")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHigh)]
        public M2TDataGridViewCellStyleColorRoleSelection RowHeadersDefaultCellStyleColorRole
        {
            get => RowHeadersDefaultCellStyle.ColorRole;
            set
            {
                RowHeadersDefaultCellStyle.ColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }

        [Description("The Material Design Color Role used to determine background and text of the CellStyle when selected")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Primary)]
        public M2TDataGridViewCellStyleColorRoleSelection RowHeadersDefaultCellStyleSelectionColorRole
        {
            get => RowHeadersDefaultCellStyle.SelectionColorRole;
            set
            {
                RowHeadersDefaultCellStyle.SelectionColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }


        public M2TDataGridView()
        {
            EnableHeadersVisualStyles = false;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 2, 0, 2);

            this.DefaultCellStyle = new M2TDataGridViewCellStyle();
            this.ColumnHeadersDefaultCellStyle = new M2TDataGridViewCellStyle();
            this.RowHeadersDefaultCellStyle = new M2TDataGridViewCellStyle();

            DefaultCellStyleColorRole = M2TDataGridViewCellStyleColorRoleSelection.Surface;
            DefaultCellStyleSelectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Primary;

            ColumnHeadersDefaultCellStyleColorRole = M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHigh;
            ColumnHeadersDefaultCellStyleSelectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Primary;

            RowHeadersDefaultCellStyleColorRole = M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHigh;
            RowHeadersDefaultCellStyleSelectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Primary;

            ApplyCurrentLoadedTheme();
        }


        public void ApplyCurrentLoadedTheme()
        {
            var backColorRole = GetMappedColorRole(BackgroundColorRole);
            this.BackgroundColor = CurrentLoadedThemeManager.GetColorForRole(backColorRole);
            var gridColorRole = GetMappedColorRole(GridColorRole);
            this.GridColor = CurrentLoadedThemeManager.GetColorForRole(gridColorRole);

            DefaultCellStyle.ApplyCurrentLoadedTheme(); 
            RowHeadersDefaultCellStyle.ApplyCurrentLoadedTheme();
            ColumnHeadersDefaultCellStyle.ApplyCurrentLoadedTheme();
        }

        private ColorRoles GetMappedColorRole(M2TDataGridViewBackgroundColorSelection backColorSelection)
        {
            return backColorSelection switch
            {
                M2TDataGridViewBackgroundColorSelection.Primary => ColorRoles.Primary,
                M2TDataGridViewBackgroundColorSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TDataGridViewBackgroundColorSelection.Secondary => ColorRoles.Secondary,
                M2TDataGridViewBackgroundColorSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TDataGridViewBackgroundColorSelection.Tertiary => ColorRoles.Tertiary,
                M2TDataGridViewBackgroundColorSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TDataGridViewBackgroundColorSelection.Error => ColorRoles.Error,
                M2TDataGridViewBackgroundColorSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TDataGridViewBackgroundColorSelection.Surface => ColorRoles.Surface,
                M2TDataGridViewBackgroundColorSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TDataGridViewBackgroundColorSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TDataGridViewBackgroundColorSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TDataGridViewBackgroundColorSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TDataGridViewBackgroundColorSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new NotImplementedException()
            };
        }
        private ColorRoles GetMappedColorRole(M2TDataGridViewGridColorSelection backColorSelection)
        {
            return backColorSelection switch
            {
                M2TDataGridViewGridColorSelection.Primary => ColorRoles.Primary,
                M2TDataGridViewGridColorSelection.OnPrimary => ColorRoles.OnPrimary,
                M2TDataGridViewGridColorSelection.OnPrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TDataGridViewGridColorSelection.Secondary => ColorRoles.Secondary,
                M2TDataGridViewGridColorSelection.OnSecondary => ColorRoles.OnSecondary,
                M2TDataGridViewGridColorSelection.OnSecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TDataGridViewGridColorSelection.Tertiary => ColorRoles.Tertiary,
                M2TDataGridViewGridColorSelection.OnTertiary => ColorRoles.OnTertiary,
                M2TDataGridViewGridColorSelection.OnTertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TDataGridViewGridColorSelection.Error => ColorRoles.Error,
                M2TDataGridViewGridColorSelection.OnError => ColorRoles.OnError,
                M2TDataGridViewGridColorSelection.OnErrorContainer => ColorRoles.OnErrorContainer,
                M2TDataGridViewGridColorSelection.Surface => ColorRoles.Surface,
                M2TDataGridViewGridColorSelection.OnSurface => ColorRoles.OnSurface,
                M2TDataGridViewGridColorSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new NotImplementedException()
            };
        }

    }
}
