using M2TWinForms.Controls.Inputs.Buttons;
using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace M2TWinForms
{
    public partial class M2TCheckBox : CheckBox, IThemedControl
    {
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }
        [Obsolete("Should not be set directly. Instead use the color roles to ensure proper theming.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color BoxColor { get; private set; }
        public Color OnBoxColor { get; private set; }


        [Description("The Material Design Color Role used for the text of the CheckBox")]
        [Category("Material Design")]
        [DefaultValue(M2TCheckBoxTextColorRoleSelection.OnSurface)]
        public M2TCheckBoxTextColorRoleSelection ForeColorRole
        {
            get => _foreColorRole;
            set
            {
                _foreColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TCheckBoxTextColorRoleSelection _foreColorRole = M2TCheckBoxTextColorRoleSelection.OnSurface;

        [Description("The Material Design Color Role used for the background of the CheckBox")]
        [Category("Material Design")]
        [DefaultValue(M2TCheckBoxBackgroundColorRoleSelection.Transparent)]
        public M2TCheckBoxBackgroundColorRoleSelection BackColorRole
        {
            get => _backColorRole;
            set
            {
                _backColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TCheckBoxBackgroundColorRoleSelection _backColorRole = M2TCheckBoxBackgroundColorRoleSelection.Transparent;

        [Description("The Material Design Color Role used for the background of the CheckBox")]
        [Category("Material Design")]
        [DefaultValue(M2TCheckBoxBoxColorRoleSelection.OnSurfaceVariant)]
        public M2TCheckBoxBoxColorRoleSelection BoxColorRole
        {
            get => _boxColorRole;
            set
            {
                _boxColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TCheckBoxBoxColorRoleSelection _boxColorRole = M2TCheckBoxBoxColorRoleSelection.OnSurfaceVariant;

        [Description("The Material Design Color Role used for the background of the CheckBox")]
        [Category("Material Design")]
        [DefaultValue(M2TCheckBoxOnBoxColorRoleSelection.Transparent)]
        public M2TCheckBoxOnBoxColorRoleSelection OnBoxColorRole
        {
            get => _onBoxColorRole;
            set
            {
                _onBoxColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TCheckBoxOnBoxColorRoleSelection _onBoxColorRole = M2TCheckBoxOnBoxColorRoleSelection.Transparent;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new FlatButtonAppearance FlatAppearance
        {
            get => base.FlatAppearance;
        }
        [DefaultValue(FlatStyle.Standard)]
        public new FlatStyle FlatStyle
        {
            get => base.FlatStyle;
            set => base.FlatStyle = value;
        }

        public M2TCheckBox()
        {
            FlatStyle = FlatStyle.Standard;
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            if (BackColorRole == M2TCheckBoxBackgroundColorRoleSelection.Transparent)
            {
                this.BackColor = Color.Empty;
            }
            else
            {
                var mappedBackColorRole = GetMappedBackColorRole();
                this.BackColor = CurrentLoadedThemeManager.GetColorForRole(mappedBackColorRole);
            }
            var mappedForeColorRole = GetMappedForeColorRole();
            this.ForeColor = CurrentLoadedThemeManager.GetColorForRole(mappedForeColorRole);
            var mappedBoxColorRole = GetMappedBoxColorRole();
            this.BoxColor = CurrentLoadedThemeManager.GetColorForRole(mappedBoxColorRole);
            if (OnBoxColorRole == M2TCheckBoxOnBoxColorRoleSelection.Transparent)
            {
                this.OnBoxColor = BackColor;
            }
            else
            {
                var mappedOnBoxColorRole = GetMappedOnBoxColorRole();
                this.OnBoxColor = CurrentLoadedThemeManager.GetColorForRole(mappedOnBoxColorRole);
            }
            Invalidate();
        }

        private ColorRoles GetMappedForeColorRole()
        {
            return ForeColorRole switch
            {
                M2TCheckBoxTextColorRoleSelection.Primary => ColorRoles.Primary,
                M2TCheckBoxTextColorRoleSelection.OnPrimary => ColorRoles.OnPrimary,
                M2TCheckBoxTextColorRoleSelection.OnPrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TCheckBoxTextColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TCheckBoxTextColorRoleSelection.OnSecondary => ColorRoles.OnSecondary,
                M2TCheckBoxTextColorRoleSelection.OnSecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TCheckBoxTextColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TCheckBoxTextColorRoleSelection.OnTertiary => ColorRoles.OnTertiary,
                M2TCheckBoxTextColorRoleSelection.OnTertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TCheckBoxTextColorRoleSelection.Error => ColorRoles.Error,
                M2TCheckBoxTextColorRoleSelection.OnError => ColorRoles.OnError,
                M2TCheckBoxTextColorRoleSelection.OnErrorContainer => ColorRoles.OnErrorContainer,
                M2TCheckBoxTextColorRoleSelection.OnSurface => ColorRoles.OnSurface,
                M2TCheckBoxTextColorRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Unknown {nameof(M2TCheckBoxTextColorRoleSelection)} value: {ForeColorRole}"),
            };
        }

        private ColorRoles GetMappedBackColorRole()
        {
            return BackColorRole switch
            {
                M2TCheckBoxBackgroundColorRoleSelection.Primary => ColorRoles.Primary,
                M2TCheckBoxBackgroundColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TCheckBoxBackgroundColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TCheckBoxBackgroundColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TCheckBoxBackgroundColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TCheckBoxBackgroundColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TCheckBoxBackgroundColorRoleSelection.Error => ColorRoles.Error,
                M2TCheckBoxBackgroundColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TCheckBoxBackgroundColorRoleSelection.Surface => ColorRoles.Surface,
                M2TCheckBoxBackgroundColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TCheckBoxBackgroundColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TCheckBoxBackgroundColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TCheckBoxBackgroundColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TCheckBoxBackgroundColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new ArgumentException($"Unknown {nameof(M2TCheckBoxBackgroundColorRoleSelection)} value: {BackColorRole}"),
            };
        }
        private ColorRoles GetMappedBoxColorRole()
        {
            return BoxColorRole switch
            {
                M2TCheckBoxBoxColorRoleSelection.Primary => ColorRoles.Primary,
                M2TCheckBoxBoxColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TCheckBoxBoxColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TCheckBoxBoxColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TCheckBoxBoxColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TCheckBoxBoxColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TCheckBoxBoxColorRoleSelection.Error => ColorRoles.Error,
                M2TCheckBoxBoxColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TCheckBoxBoxColorRoleSelection.OnSurface => ColorRoles.OnSurface,
                M2TCheckBoxBoxColorRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Unknown {nameof(M2TCheckBoxBoxColorRoleSelection)} value: {BoxColorRole}"),
            };
        }
        private ColorRoles GetMappedOnBoxColorRole()
        {
            return OnBoxColorRole switch
            {
                M2TCheckBoxOnBoxColorRoleSelection.OnPrimary => ColorRoles.OnPrimary,
                M2TCheckBoxOnBoxColorRoleSelection.OnPrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TCheckBoxOnBoxColorRoleSelection.OnSecondary => ColorRoles.OnSecondary,
                M2TCheckBoxOnBoxColorRoleSelection.OnSecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TCheckBoxOnBoxColorRoleSelection.OnTertiary => ColorRoles.OnTertiary,
                M2TCheckBoxOnBoxColorRoleSelection.OnTertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TCheckBoxOnBoxColorRoleSelection.OnError => ColorRoles.OnError,
                M2TCheckBoxOnBoxColorRoleSelection.OnErrorContainer => ColorRoles.OnErrorContainer,
                _ => throw new ArgumentException($"Unknown {nameof(M2TCheckBoxOnBoxColorRoleSelection)} value: {OnBoxColorRole}"),
            };
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.Clear(BackColor);

            using (SolidBrush brush = new SolidBrush(ForeColor))
                pevent.Graphics.DrawString(Text, Font, brush, 18, 1);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Point pt = new Point(0, 1);
            Rectangle rect = new Rectangle(pt, new Size(16, 16));

            if (CheckState == CheckState.Checked)
            {
                var path = CreateRoundedRect(rect, 3);
                var fillBrush = new SolidBrush(BoxColor);
                pevent.Graphics.FillPath(fillBrush, path);

                var checkPath = new GraphicsPath();
                var startPoint = new Point(2, 9);
                var midPoint = new Point(6, 13);
                var endPoint = new Point(14, 4);
                checkPath.AddLine(startPoint, midPoint);
                checkPath.AddLine(midPoint, endPoint);
                var checkPen = new Pen(OnBoxColor, 3);
                pevent.Graphics.DrawPath(checkPen, checkPath);
            }
            else if (CheckState == CheckState.Indeterminate)
            {
                var path = CreateRoundedRect(rect, 3);
                var fillBrush = new SolidBrush(BoxColor);
                pevent.Graphics.FillPath(fillBrush, path);

                var indeterminatePath = new GraphicsPath();
                var startPoint = new Point(2, 9);
                var endPoint = new Point(14, 9);
                var checkPen = new Pen(OnBoxColor, 3);
                pevent.Graphics.DrawLine(checkPen, startPoint, endPoint);
            }
            else if (CheckState == CheckState.Unchecked)
            {
                rect.Inflate(-1, -1);
                var path = CreateRoundedRect(rect, 3);
                var outlinePen = new Pen(BoxColor, 2);
                pevent.Graphics.DrawPath(outlinePen, path);
            }
        }


        private static GraphicsPath CreateRoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
            return path;
        }

    }
}
