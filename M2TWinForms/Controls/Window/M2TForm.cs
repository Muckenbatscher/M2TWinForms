using M2TWinForms.Helper;
using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System.ComponentModel;
using System.Diagnostics;

namespace M2TWinForms.Controls.Window
{
    public partial class M2TForm : BorderlessForm, IThemedControl
    {
        
        #region Color Roles
        [Description("The Material Design Color Role used for background of the form")]
        [Category("Material Design")]
        [DefaultValue(M2TFormBackgroundRoleSelection.Surface)]
        public M2TFormBackgroundRoleSelection BackgroundColorRole
        {
            get => _backgroundColorRole;
            set
            {
                _backgroundColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormBackgroundRoleSelection _backgroundColorRole;

        [Description("The Material Design Color Role used for titlebar of the form containing the control buttons")]
        [Category("Material Design")]
        [DefaultValue(M2TFormBackgroundRoleSelection.SurfaceContainerHigh)]
        public M2TFormBackgroundRoleSelection TitleBarColorRole
        {
            get => _titleBarColorRole;
            set
            {
                _titleBarColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormBackgroundRoleSelection _titleBarColorRole;

        [Description("The Material Design Color Role used for the hover color of the control buttons in the titlebar")]
        [Category("Material Design")]
        [DefaultValue(M2TFormBackgroundRoleSelection.SurfaceContainer)]
        public M2TFormBackgroundRoleSelection TitleBarButtonHoverColorRole
        {
            get => _titleBarButtonHoverColorRole;
            set
            {
                _titleBarButtonHoverColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormBackgroundRoleSelection _titleBarButtonHoverColorRole;

        [Description("The Material Design Color Role used for the foreground color of the control buttons and window title text in the titlebar")]
        [Category("Material Design")]
        [DefaultValue(M2TFormForegroundRoleSelection.OnSurface)]
        public M2TFormForegroundRoleSelection TitleBarForegroundColorRole
        {
            get => _titleBarForegroundColorRole;
            set
            {
                _titleBarForegroundColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormForegroundRoleSelection _titleBarForegroundColorRole;

        [Description("The Material Design Color Role used for the foreground color of the close button in the titlebar")]
        [Category("Material Design")]
        [DefaultValue(M2TFormForegroundRoleSelection.Error)]
        public M2TFormForegroundRoleSelection CloseButtonColorRole
        {
            get => _closeButtonColorRole;
            set
            {
                _closeButtonColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormForegroundRoleSelection _closeButtonColorRole;
        #endregion


        public M2TForm()
        {
            InitializeComponent();

            TitleBarForegroundColorRole = M2TFormForegroundRoleSelection.OnSurface;
            BackgroundColorRole = M2TFormBackgroundRoleSelection.Surface;
            TitleBarColorRole = M2TFormBackgroundRoleSelection.SurfaceContainerHigh;
            TitleBarButtonHoverColorRole = M2TFormBackgroundRoleSelection.SurfaceContainer;
            CloseButtonColorRole = M2TFormForegroundRoleSelection.Error;

            ApplyCurrentLoadedTheme();
        }


        public void ApplyCurrentLoadedTheme()
        {
            this.BackColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(BackgroundColorRole));
            TitleBarColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(TitleBarColorRole));
            TitleBarForegroundColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(TitleBarForegroundColorRole));
            CloseButtonColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(CloseButtonColorRole));
            TitleBarButtonHoverColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(TitleBarButtonHoverColorRole));

            NestedControlThemeApplier.ApplyThemeForChildControls(this);
        }

        private ColorRoles GetMappedRole(M2TFormBackgroundRoleSelection role)
        {
            return role switch
            {
                M2TFormBackgroundRoleSelection.Surface => ColorRoles.Surface,
                M2TFormBackgroundRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TFormBackgroundRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                M2TFormBackgroundRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TFormBackgroundRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TFormBackgroundRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                _ => throw new ArgumentException($"Could not map {nameof(M2TFormBackgroundRoleSelection)}: {role}"),
            };
        }

        private ColorRoles GetMappedRole(M2TFormForegroundRoleSelection role)
        {
            return role switch
            {
                M2TFormForegroundRoleSelection.Primary => ColorRoles.Primary,
                M2TFormForegroundRoleSelection.Secondary => ColorRoles.Secondary,
                M2TFormForegroundRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TFormForegroundRoleSelection.Error => ColorRoles.Error,
                M2TFormForegroundRoleSelection.OnSurface => ColorRoles.OnSurface,
                M2TFormForegroundRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Could not map {nameof(M2TFormForegroundRoleSelection)}: {role}"),
            };
        }

    }
}
