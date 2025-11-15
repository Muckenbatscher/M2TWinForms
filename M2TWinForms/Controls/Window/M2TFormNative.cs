using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System.ComponentModel;

namespace M2TWinForms.Controls.Window;

public partial class M2TFormNative : Form, IThemedControl
{
    #region Color Roles
    [Description("The Material Design Color Role used for background of the form")]
    [Category("Material Design")]
    [DefaultValue(M2TFormBackgroundRoleSelection.Surface)]
    public M2TFormBackgroundRoleSelection BackgroundColorRole
    {
        get;
        set
        {
            field = value;
            ApplyCurrentLoadedTheme();
        }
    }

    [Description("The Material Design Color Role used for titlebar of the form containing the control buttons")]
    [Category("Material Design")]
    [DefaultValue(M2TFormBackgroundRoleSelection.SurfaceContainerHigh)]
    public M2TFormBackgroundRoleSelection TitleBarColorRole
    {
        get;
        set
        {
            field = value;
            ApplyCurrentLoadedTheme();
        }
    }

    [Description("The Material Design Color Role used for the foreground color of the control buttons and window title text in the titlebar")]
    [Category("Material Design")]
    [DefaultValue(M2TFormForegroundRoleSelection.OnSurface)]
    public M2TFormForegroundRoleSelection TitleBarForegroundColorRole
    {
        get;
        set
        {
            field = value;
            ApplyCurrentLoadedTheme();
        }
    }

    [Description("The Material Design Color Role used for the color of the form border when the window is active")]
    [Category("Material Design")]
    [DefaultValue(M2TFormBorderColorRoleSelection.Primary)]
    public M2TFormBorderColorRoleSelection FormBorderActiveColorRole
    {
        get;
        set
        {
            field = value;
            RefreshFormBorderColor();
        }
    }

    [Description("The Material Design Color Role used for the color of the form border when the window is inactive")]
    [Category("Material Design")]
    [DefaultValue(M2TFormBorderColorRoleSelection.SurfaceContainerHigh)]
    public M2TFormBorderColorRoleSelection FormBorderInactiveColorRole
    {
        get;
        set
        {
            field = value;
            RefreshFormBorderColor();
        }
    }
    #endregion


    public M2TFormNative()
    {
        InitializeComponent();

        BackgroundColorRole = M2TFormBackgroundRoleSelection.Surface;
        TitleBarColorRole = M2TFormBackgroundRoleSelection.SurfaceContainerHigh;
        TitleBarForegroundColorRole = M2TFormForegroundRoleSelection.OnSurface;
        FormBorderActiveColorRole = M2TFormBorderColorRoleSelection.Primary;
        FormBorderInactiveColorRole = M2TFormBorderColorRoleSelection.SurfaceContainerHigh;
    }

    private void M2TForm_Load(object sender, EventArgs e)
    {
        ApplyCurrentLoadedTheme();
    }

    public void ApplyCurrentLoadedTheme()
    {
        BackColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(BackgroundColorRole));
        FormCaptionBackColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(TitleBarColorRole));
        FormCaptionTextColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(TitleBarForegroundColorRole));
        RefreshFormBorderColor();

        NestedControlThemeApplier.ApplyThemeForChildControls(this);
    }

    protected bool IsActivated { get; private set; } = false;
    private void M2TForm_Activated(object sender, EventArgs e)
    {
        IsActivated = true;
        RefreshFormBorderColor();
    }
    private void M2TForm_Deactivated(object sender, EventArgs e)
    {
        IsActivated = false;
        RefreshFormBorderColor();
    }
    private void RefreshFormBorderColor()
    {
        var formBorderColorRole = IsActivated
            ? GetMappedColorRole(FormBorderActiveColorRole)
            : GetMappedColorRole(FormBorderInactiveColorRole);
        FormBorderColor = CurrentLoadedThemeManager.GetColorForRole(formBorderColorRole);
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

    private ColorRoles GetMappedColorRole(M2TFormBorderColorRoleSelection role)
    {
        return role switch
        {
            M2TFormBorderColorRoleSelection.Primary => ColorRoles.Primary,
            M2TFormBorderColorRoleSelection.Secondary => ColorRoles.Secondary,
            M2TFormBorderColorRoleSelection.Tertiary => ColorRoles.Tertiary,
            M2TFormBorderColorRoleSelection.Error => ColorRoles.Error,
            M2TFormBorderColorRoleSelection.Surface => ColorRoles.Surface,
            M2TFormBorderColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
            M2TFormBorderColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
            M2TFormBorderColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
            M2TFormBorderColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
            M2TFormBorderColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
            M2TFormBorderColorRoleSelection.OnSurface => ColorRoles.OnSurface,
            M2TFormBorderColorRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
            _ => throw new ArgumentException($"Could not map {nameof(M2TFormBorderColorRoleSelection)}: {role}"),
        };
    }
}
