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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        //[Editor(typeof(M2TDataGridViewColumnCollectionEditorForDesigner), typeof(System.Drawing.Design.UITypeEditor))]
        public new M2TDataGridViewColumnCollection Columns
        {
            get => (M2TDataGridViewColumnCollection)base.Columns;
        }
        protected override DataGridViewColumnCollection CreateColumnsInstance()
        {
            return new M2TDataGridViewColumnCollection(this);
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
        [DefaultValue(M2TDataGridViewBackgroundColorSelection.Surface)]
        public M2TDataGridViewBackgroundColorSelection BackgroundColorRole
        {
            get => _bckgroundColorRole;
            set
            {
                _bckgroundColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TDataGridViewBackgroundColorSelection _bckgroundColorRole = M2TDataGridViewBackgroundColorSelection.Surface;

        public M2TDataGridView()
        {
            //TypeDescriptor.AddProvider(new M2TDataGridViewColumnTypeDescriptionProvider(), typeof(DataGridViewColumnCollection));
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            var backColorRole = GetMappedColorRole(BackgroundColorRole);
            this.BackgroundColor = CurrentLoadedThemeManager.GetColorForRole(backColorRole);
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


    }
}
