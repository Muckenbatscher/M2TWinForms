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
        [DefaultValue(BorderStyle.None)]
        public new BorderStyle BorderStyle
        {
            get => base.BorderStyle;
            set => base.BorderStyle = value;
        }

        #region BackgroundColor
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
        #endregion BackgroundColor

        #region GridColor
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
        #endregion GridColor

        #region DefaultCellStyle
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
        #endregion DefaultCellStyle

        #region ColumnHeadersDefaultCellStyle
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
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Empty)]
        public M2TDataGridViewCellStyleColorRoleSelection ColumnHeadersDefaultCellStyleSelectionColorRole
        {
            get => ColumnHeadersDefaultCellStyle.SelectionColorRole;
            set
            {
                ColumnHeadersDefaultCellStyle.SelectionColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        #endregion ColumnHeadersDefaultCellStyle

        #region RowHeadersDefaultCellStyle
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
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Empty)]
        public M2TDataGridViewCellStyleColorRoleSelection RowHeadersDefaultCellStyleSelectionColorRole
        {
            get => RowHeadersDefaultCellStyle.SelectionColorRole;
            set
            {
                RowHeadersDefaultCellStyle.SelectionColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        #endregion RowHeadersDefaultCellStyle

        #region RowsDefaultCellStyle
        public new M2TDataGridViewCellStyle RowsDefaultCellStyle
        {
            get
            {
                if (base.RowsDefaultCellStyle is M2TDataGridViewCellStyle m2tStyle)
                    return m2tStyle;
                var newM2tStyle = new M2TDataGridViewCellStyle(base.RowsDefaultCellStyle);
                base.RowsDefaultCellStyle = newM2tStyle;
                return newM2tStyle;
            }
            set => base.RowsDefaultCellStyle = value;
        }
        [Description("The Material Design Color Role used to determine background and text of the CellStyle")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Empty)]
        public M2TDataGridViewCellStyleColorRoleSelection RowsDefaultCellStyleColorRole
        {
            get => RowsDefaultCellStyle.ColorRole;
            set
            {
                RowsDefaultCellStyle.ColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        [Description("The Material Design Color Role used to determine background and text of the CellStyle when selected")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Empty)]
        public M2TDataGridViewCellStyleColorRoleSelection RowsDefaultCellStyleSelectionColorRole
        {
            get => RowsDefaultCellStyle.SelectionColorRole;
            set
            {
                RowsDefaultCellStyle.SelectionColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        #endregion RowsDefaultCellStyle 

        #region AlternatingRowsDefaultCellStyle
        public new M2TDataGridViewCellStyle AlternatingRowsDefaultCellStyle
        {
            get
            {
                if (base.AlternatingRowsDefaultCellStyle is M2TDataGridViewCellStyle m2tStyle)
                    return m2tStyle;
                var newM2tStyle = new M2TDataGridViewCellStyle(base.AlternatingRowsDefaultCellStyle);
                base.AlternatingRowsDefaultCellStyle = newM2tStyle;
                return newM2tStyle;
            }
            set => base.AlternatingRowsDefaultCellStyle = value;
        }
        [Description("The Material Design Color Role used to determine background and text of the CellStyle")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Empty)]
        public M2TDataGridViewCellStyleColorRoleSelection AlternatingRowsDefaultCellStyleColorRole
        {
            get => AlternatingRowsDefaultCellStyle.ColorRole;
            set
            {
                AlternatingRowsDefaultCellStyle.ColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        [Description("The Material Design Color Role used to determine background and text of the CellStyle when selected")]
        [Category("Material Design")]
        [DefaultValue(M2TDataGridViewCellStyleColorRoleSelection.Empty)]
        public M2TDataGridViewCellStyleColorRoleSelection AlternatingRowsDefaultCellStyleSelectionColorRole
        {
            get => AlternatingRowsDefaultCellStyle.SelectionColorRole;
            set
            {
                AlternatingRowsDefaultCellStyle.SelectionColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        #endregion

        public M2TDataGridView()
        {
            EnableHeadersVisualStyles = false;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            BorderStyle = BorderStyle.None;
            ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 2, 0, 2);

            this.DefaultCellStyle = new M2TDataGridViewCellStyle();
            this.ColumnHeadersDefaultCellStyle = new M2TDataGridViewCellStyle();
            this.RowHeadersDefaultCellStyle = new M2TDataGridViewCellStyle();
            this.RowsDefaultCellStyle = new M2TDataGridViewCellStyle();
            this.AlternatingRowsDefaultCellStyle = new M2TDataGridViewCellStyle();

            DefaultCellStyleColorRole = M2TDataGridViewCellStyleColorRoleSelection.Surface;
            DefaultCellStyleSelectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Primary;

            ColumnHeadersDefaultCellStyleColorRole = M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHigh;
            ColumnHeadersDefaultCellStyleSelectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Empty;

            RowHeadersDefaultCellStyleColorRole = M2TDataGridViewCellStyleColorRoleSelection.SurfaceContainerHigh;
            RowHeadersDefaultCellStyleSelectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Empty;

            RowsDefaultCellStyleColorRole = M2TDataGridViewCellStyleColorRoleSelection.Empty;
            RowsDefaultCellStyleSelectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Empty;

            AlternatingRowsDefaultCellStyleColorRole = M2TDataGridViewCellStyleColorRoleSelection.Empty;
            AlternatingRowsDefaultCellStyleSelectionColorRole = M2TDataGridViewCellStyleColorRoleSelection.Empty;

            ApplyCurrentLoadedTheme();

            this.ColumnStateChanged += M2TDataGridView_ColumnStateChanged;
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
        private void M2TDataGridView_ColumnStateChanged(object? sender, DataGridViewColumnStateChangedEventArgs e)
        {
            M2TDataGridView dataGridView = (M2TDataGridView)sender!;
            if (dataGridView.SelectionMode == DataGridViewSelectionMode.FullRowSelect)
                e.Column.HeaderCell.Style.SelectionBackColor = dataGridView.ColumnHeadersDefaultCellStyle.BackColor;
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
                M2TDataGridViewGridColorSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TDataGridViewGridColorSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TDataGridViewGridColorSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TDataGridViewGridColorSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TDataGridViewGridColorSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new NotImplementedException()
            };
        }

    }
}
