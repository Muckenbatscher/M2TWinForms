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
        public Color CheckColorChecked { get; private set; }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color CheckColorUnchecked { get; private set; }


        [Description("The Material Design Color Role used for the text of the RadioButton")]
        [Category("Material Design")]
        [DefaultValue(M2TRadioButtonTextColorRoleSelection.OnSurface)]
        public M2TRadioButtonTextColorRoleSelection TextColorRole
        {
            get => _foreColorRole;
            set
            {
                _foreColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TRadioButtonTextColorRoleSelection _foreColorRole = M2TRadioButtonTextColorRoleSelection.OnSurface;

        [Description("The Material Design Color Role used for the background of the RadioButton")]
        [Category("Material Design")]
        [DefaultValue(M2TRadioButtonBackgroundColorRoleSelection.Transparent)]
        public M2TRadioButtonBackgroundColorRoleSelection BackColorRole
        {
            get => _backColorRole;
            set
            {
                _backColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TRadioButtonBackgroundColorRoleSelection _backColorRole = M2TRadioButtonBackgroundColorRoleSelection.Transparent;

        [Description("The Material Design Color Role used for the check part of the RadioButton when checked")]
        [Category("Material Design")]
        [DefaultValue(M2TRadioButtonCheckColorRoleSelection.Primary)]
        public M2TRadioButtonCheckColorRoleSelection CheckedBoxColorRole
        {
            get => _checkedBoxColorRole;
            set
            {
                _checkedBoxColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TRadioButtonCheckColorRoleSelection _checkedBoxColorRole = M2TRadioButtonCheckColorRoleSelection.Primary;

        [Description("The Material Design Color Role used for the check part of the RadioButton when unchecked")]
        [Category("Material Design")]
        [DefaultValue(M2TRadioButtonCheckColorRoleSelection.OnSurfaceVariant)]
        public M2TRadioButtonCheckColorRoleSelection UncheckedBoxColorRole
        {
            get => _uncheckedBoxColorRole;
            set
            {
                _uncheckedBoxColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TRadioButtonCheckColorRoleSelection _uncheckedBoxColorRole = M2TRadioButtonCheckColorRoleSelection.OnSurfaceVariant;

        [DefaultValue(FlatStyle.Standard)]
        public new FlatStyle FlatStyle
        {
            get => base.FlatStyle;
            set
            {
                base.FlatStyle = value;
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new FlatButtonAppearance FlatAppearance
        {
            get => base.FlatAppearance;
        }

        public M2TRadioButton()
        {
            FlatStyle = FlatStyle.Standard;
            ApplyCurrentLoadedTheme();

            this.AppearanceChanged += (s, e) => ApplyCurrentLoadedTheme();
            this.CheckedChanged += (s, e) => ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            RefreshColorsForAppearance();
            Invalidate();
        }

        private void RefreshColorsForAppearance()
        {
            if (Appearance == Appearance.Normal)
                SetColorsForNormalAppearance();
            else if (Appearance == Appearance.Button)
                SetColorsForButtonAppearance();
        }
        private void SetColorsForNormalAppearance()
        {
            if (BackColorRole == M2TRadioButtonBackgroundColorRoleSelection.Transparent)
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

            var mappedCheckedBoxColorRole = GetMappedBoxColorRole(true);
            this.CheckColorChecked = CurrentLoadedThemeManager.GetColorForRole(mappedCheckedBoxColorRole);
            var mappedUncheckedBoxColorRole = GetMappedBoxColorRole(false);
            this.CheckColorUnchecked = CurrentLoadedThemeManager.GetColorForRole(mappedUncheckedBoxColorRole);
        }
        private void SetColorsForButtonAppearance()
        {
            var mappedForeColorRole = GetMappedBoxTextColorRole(Checked);
            this.ForeColor = CurrentLoadedThemeManager.GetColorForRole(mappedForeColorRole);

            if (RequiresSurfaceBackColorRole())
            {
                BackColor = CurrentLoadedThemeManager.GetColorForRole(ColorRoles.Surface);
            }
            else
            {
                var mappedCheckedBoxColorRole = GetMappedBoxColorRole(true);
                CheckColorChecked = CurrentLoadedThemeManager.GetColorForRole(mappedCheckedBoxColorRole);
                var mappedUncheckedBoxColorRole = GetMappedBoxColorRole(false);
                CheckColorUnchecked = CurrentLoadedThemeManager.GetColorForRole(mappedUncheckedBoxColorRole);
                this.BackColor = CheckColorUnchecked;
                this.FlatAppearance.CheckedBackColor = CheckColorChecked;
            }

            this.FlatAppearance.BorderColor = this.ForeColor;
        }

        private bool RequiresSurfaceBackColorRole()
        {
            var roleToBeUsed = Checked ? CheckedBoxColorRole : UncheckedBoxColorRole;
            var rolesRequiringSurface = new M2TRadioButtonCheckColorRoleSelection[]
            {
                M2TRadioButtonCheckColorRoleSelection.OnSurface,
                M2TRadioButtonCheckColorRoleSelection.OnSurfaceVariant
            };
            return rolesRequiringSurface.Contains(roleToBeUsed);
        }

        private ColorRoles GetMappedForeColorRole()
        {
            return TextColorRole switch
            {
                M2TRadioButtonTextColorRoleSelection.Primary => ColorRoles.Primary,
                M2TRadioButtonTextColorRoleSelection.OnPrimary => ColorRoles.OnPrimary,
                M2TRadioButtonTextColorRoleSelection.OnPrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TRadioButtonTextColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TRadioButtonTextColorRoleSelection.OnSecondary => ColorRoles.OnSecondary,
                M2TRadioButtonTextColorRoleSelection.OnSecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TRadioButtonTextColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TRadioButtonTextColorRoleSelection.OnTertiary => ColorRoles.OnTertiary,
                M2TRadioButtonTextColorRoleSelection.OnTertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TRadioButtonTextColorRoleSelection.Error => ColorRoles.Error,
                M2TRadioButtonTextColorRoleSelection.OnError => ColorRoles.OnError,
                M2TRadioButtonTextColorRoleSelection.OnErrorContainer => ColorRoles.OnErrorContainer,
                M2TRadioButtonTextColorRoleSelection.OnSurface => ColorRoles.OnSurface,
                M2TRadioButtonTextColorRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Unknown {nameof(M2TRadioButtonTextColorRoleSelection)} value: {TextColorRole}"),
            };
        }

        private ColorRoles GetMappedBackColorRole()
        {
            return BackColorRole switch
            {
                M2TRadioButtonBackgroundColorRoleSelection.Primary => ColorRoles.Primary,
                M2TRadioButtonBackgroundColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TRadioButtonBackgroundColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TRadioButtonBackgroundColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TRadioButtonBackgroundColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TRadioButtonBackgroundColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TRadioButtonBackgroundColorRoleSelection.Error => ColorRoles.Error,
                M2TRadioButtonBackgroundColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TRadioButtonBackgroundColorRoleSelection.Surface => ColorRoles.Surface,
                M2TRadioButtonBackgroundColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TRadioButtonBackgroundColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TRadioButtonBackgroundColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TRadioButtonBackgroundColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TRadioButtonBackgroundColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new ArgumentException($"Unknown {nameof(M2TRadioButtonBackgroundColorRoleSelection)} value: {BackColorRole}"),
            };
        }
        private ColorRoles GetMappedBoxColorRole(bool isChecked)
        {
            var role = isChecked ? CheckedBoxColorRole : UncheckedBoxColorRole;
            return role switch
            {
                M2TRadioButtonCheckColorRoleSelection.Primary => ColorRoles.Primary,
                M2TRadioButtonCheckColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TRadioButtonCheckColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TRadioButtonCheckColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TRadioButtonCheckColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TRadioButtonCheckColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TRadioButtonCheckColorRoleSelection.Error => ColorRoles.Error,
                M2TRadioButtonCheckColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TRadioButtonCheckColorRoleSelection.OnSurface => ColorRoles.OnSurface,
                M2TRadioButtonCheckColorRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Unknown {nameof(M2TRadioButtonCheckColorRoleSelection)} value: {role}"),
            };
        }
        private ColorRoles GetMappedBoxTextColorRole(bool isChecked)
        {
            var role = isChecked ? CheckedBoxColorRole : UncheckedBoxColorRole;
            return role switch
            {
                M2TRadioButtonCheckColorRoleSelection.Primary => ColorRoles.OnPrimary,
                M2TRadioButtonCheckColorRoleSelection.PrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TRadioButtonCheckColorRoleSelection.Secondary => ColorRoles.OnSecondary,
                M2TRadioButtonCheckColorRoleSelection.SecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TRadioButtonCheckColorRoleSelection.Tertiary => ColorRoles.OnTertiary,
                M2TRadioButtonCheckColorRoleSelection.TertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TRadioButtonCheckColorRoleSelection.Error => ColorRoles.OnError,
                M2TRadioButtonCheckColorRoleSelection.ErrorContainer => ColorRoles.OnErrorContainer,
                M2TRadioButtonCheckColorRoleSelection.OnSurface => ColorRoles.OnSurface,
                M2TRadioButtonCheckColorRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Unknown {nameof(M2TRadioButtonCheckColorRoleSelection)} value: {role}"),
            };
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            if (Appearance == Appearance.Normal)
            {
                pevent.Graphics.Clear(BackColor);
                PaintMaterialRadioAppearance(pevent);
            }
            else
            {
                base.OnPaint(pevent);
            }
        }

        private void PaintMaterialRadioAppearance(PaintEventArgs pevent)
        {
            using (SolidBrush brush = new SolidBrush(ForeColor))
                pevent.Graphics.DrawString(Text, Font, brush, 17, 1);

            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var pt = new Point(1, 2);
            var rect = new Rectangle(pt, new Size(14, 14));

            var checkColor = Checked ? CheckColorChecked : CheckColorUnchecked;
            var outerCirclePen = new Pen(checkColor, 1.75F);
            pevent.Graphics.DrawEllipse(outerCirclePen, rect);

            if (Checked)
            {
                rect.Inflate(-3, -3);
                var fillBrush = new SolidBrush(checkColor);
                pevent.Graphics.FillEllipse(fillBrush, rect);
            }
        }
    }
}
