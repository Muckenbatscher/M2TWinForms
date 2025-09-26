using M2TWinForms.Controls.Inputs.Buttons;
using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public class M2TRadioButton : RadioButton, IThemedControl
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
        public Color CheckCircleColor { get; private set; }


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

        
        public M2TRadioButton()
        {
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
            this.CheckCircleColor = CurrentLoadedThemeManager.GetColorForRole(mappedBoxColorRole);

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

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (Appearance == Appearance.Normal)
            {
                pevent.Graphics.Clear(BackColor);
                PaintMaterialRadioAppearance(pevent);
            }
        }

        private void PaintMaterialRadioAppearance(PaintEventArgs pevent)
        {
            using (SolidBrush brush = new SolidBrush(ForeColor))
                pevent.Graphics.DrawString(Text, Font, brush, 17, 1);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Point pt = new Point(1, 2);
            Rectangle rect = new Rectangle(pt, new Size(14, 14));

            var outerCirclePen = new Pen(CheckCircleColor, 1.75F);
            pevent.Graphics.DrawEllipse(outerCirclePen, rect);

            if (Checked)
            {
                rect.Inflate(-3, -3);
                var fillBrush = new SolidBrush(CheckCircleColor);
                pevent.Graphics.FillEllipse(fillBrush, rect);
            }
        }
    }
}
