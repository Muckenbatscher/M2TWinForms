using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Controls.UpDown
{
    public class M2TNumericUpDown : NumericUpDown, IThemedControl
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

        [DefaultValue(BorderStyle.FixedSingle)]
        public new BorderStyle BorderStyle
        {
            get => base.BorderStyle;
            set => base.BorderStyle = value;
        }


        [Description("The Material Design Color Role used for the text of the NumericUpDown")]
        [Category("Material Design")]
        [DefaultValue(M2TNumericUpDownTextColorRoleSelection.OnSurface)]
        public M2TNumericUpDownTextColorRoleSelection ForeColorRole
        {
            get => _foreColorRole;
            set
            {
                _foreColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TNumericUpDownTextColorRoleSelection _foreColorRole = M2TNumericUpDownTextColorRoleSelection.OnSurface;

        [Description("The Material Design Color Role used for the background of the NUmericUpDown")]
        [Category("Material Design")]
        [DefaultValue(M2TNumericUpDownBackgroundColorRoleSelection.Surface)]
        public M2TNumericUpDownBackgroundColorRoleSelection BackColorRole
        {
            get => _backColorRole;
            set
            {
                _backColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TNumericUpDownBackgroundColorRoleSelection _backColorRole = M2TNumericUpDownBackgroundColorRoleSelection.Surface;

        public void ApplyCurrentLoadedTheme()
        {
            var mappedBackColorRole = GetMappedBackColorRole();
            this.BackColor = CurrentLoadedThemeManager.GetColorForRole(mappedBackColorRole);
            var mappedForeColorRole = GetMappedForeColorRole();
            this.ForeColor = CurrentLoadedThemeManager.GetColorForRole(mappedForeColorRole);
            Invalidate();
        }

        private ColorRoles GetMappedForeColorRole()
        {
            return ForeColorRole switch
            {
                M2TNumericUpDownTextColorRoleSelection.Primary => ColorRoles.Primary,
                M2TNumericUpDownTextColorRoleSelection.OnPrimary => ColorRoles.OnPrimary,
                M2TNumericUpDownTextColorRoleSelection.OnPrimaryContainer => ColorRoles.OnPrimaryContainer,
                M2TNumericUpDownTextColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TNumericUpDownTextColorRoleSelection.OnSecondary => ColorRoles.OnSecondary,
                M2TNumericUpDownTextColorRoleSelection.OnSecondaryContainer => ColorRoles.OnSecondaryContainer,
                M2TNumericUpDownTextColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TNumericUpDownTextColorRoleSelection.OnTertiary => ColorRoles.OnTertiary,
                M2TNumericUpDownTextColorRoleSelection.OnTertiaryContainer => ColorRoles.OnTertiaryContainer,
                M2TNumericUpDownTextColorRoleSelection.Error => ColorRoles.Error,
                M2TNumericUpDownTextColorRoleSelection.OnError => ColorRoles.OnError,
                M2TNumericUpDownTextColorRoleSelection.OnErrorContainer => ColorRoles.OnErrorContainer,
                M2TNumericUpDownTextColorRoleSelection.OnSurface => ColorRoles.OnSurface,
                M2TNumericUpDownTextColorRoleSelection.OnSurfaceVariant => ColorRoles.OnSurfaceVariant,
                _ => throw new ArgumentException($"Unknown {nameof(M2TNumericUpDownTextColorRoleSelection)} value: {ForeColorRole}"),
            };
        }

        private ColorRoles GetMappedBackColorRole()
        {
            return BackColorRole switch
            {
                M2TNumericUpDownBackgroundColorRoleSelection.Primary => ColorRoles.Primary,
                M2TNumericUpDownBackgroundColorRoleSelection.PrimaryContainer => ColorRoles.PrimaryContainer,
                M2TNumericUpDownBackgroundColorRoleSelection.Secondary => ColorRoles.Secondary,
                M2TNumericUpDownBackgroundColorRoleSelection.SecondaryContainer => ColorRoles.SecondaryContainer,
                M2TNumericUpDownBackgroundColorRoleSelection.Tertiary => ColorRoles.Tertiary,
                M2TNumericUpDownBackgroundColorRoleSelection.TertiaryContainer => ColorRoles.TertiaryContainer,
                M2TNumericUpDownBackgroundColorRoleSelection.Error => ColorRoles.Error,
                M2TNumericUpDownBackgroundColorRoleSelection.ErrorContainer => ColorRoles.ErrorContainer,
                M2TNumericUpDownBackgroundColorRoleSelection.Surface => ColorRoles.Surface,
                M2TNumericUpDownBackgroundColorRoleSelection.SurfaceContainer => ColorRoles.SurfaceContainer,
                M2TNumericUpDownBackgroundColorRoleSelection.SurfaceContainerLowest => ColorRoles.SurfaceContainerLowest,
                M2TNumericUpDownBackgroundColorRoleSelection.SurfaceContainerLow => ColorRoles.SurfaceContainerLow,
                M2TNumericUpDownBackgroundColorRoleSelection.SurfaceContainerHigh => ColorRoles.SurfaceContainerHigh,
                M2TNumericUpDownBackgroundColorRoleSelection.SurfaceContainerHighest => ColorRoles.SurfaceContainerHighest,
                _ => throw new ArgumentException($"Unknown {nameof(M2TNumericUpDownBackgroundColorRoleSelection)} value: {BackColorRole}"),
            };
        }

        public M2TNumericUpDown() : base()
        {
            var renderer = new UpDownButtonRenderer(Controls[0]);
            BorderStyle = BorderStyle.FixedSingle;
            ApplyCurrentLoadedTheme();
        }

        //https://github.com/r-aghaei/FlatNumericUpDownExample
        #region FlatNumericUpDown
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (BorderStyle == BorderStyle.FixedSingle)
            {
                var mappedForeColorRole = GetMappedForeColorRole();
                var borderColor = CurrentLoadedThemeManager.GetColorForRole(mappedForeColorRole);
                using (var pen = new Pen(borderColor, 1))
                {
                    e.Graphics.DrawRectangle(pen,
                        ClientRectangle.Left, ClientRectangle.Top,
                        ClientRectangle.Width - 1, ClientRectangle.Height - 1);
                }
            }
        }
        private class UpDownButtonRenderer : NativeWindow
        {
            [DllImport("user32.dll", ExactSpelling = true, EntryPoint = "BeginPaint", CharSet = CharSet.Auto)]
            private static extern IntPtr IntBeginPaint(IntPtr hWnd, [In, Out] ref PAINTSTRUCT lpPaint);
            [StructLayout(LayoutKind.Sequential)]
            public struct PAINTSTRUCT
            {
                public IntPtr hdc;
                public bool fErase;
                public int rcPaint_left;
                public int rcPaint_top;
                public int rcPaint_right;
                public int rcPaint_bottom;
                public bool fRestore;
                public bool fIncUpdate;
                public int reserved1;
                public int reserved2;
                public int reserved3;
                public int reserved4;
                public int reserved5;
                public int reserved6;
                public int reserved7;
                public int reserved8;
            }
            [DllImport("user32.dll", ExactSpelling = true, EntryPoint = "EndPaint", CharSet = CharSet.Auto)]
            private static extern bool IntEndPaint(IntPtr hWnd, ref PAINTSTRUCT lpPaint);

            private readonly Control _updown;
            public UpDownButtonRenderer(Control updown)
            {
                _updown = updown;
                if (_updown.IsHandleCreated)
                    AssignHandle(_updown.Handle);
                else
                    _updown.HandleCreated += (s, e) => AssignHandle(_updown.Handle);
            }
            private Point[] GetArrowPoints(Rectangle containingRectangle, bool pointingUp)
            {
                var middle = new Point(containingRectangle.Left + containingRectangle.Width / 2,
                    containingRectangle.Top + containingRectangle.Height / 2);
                int baseOffsetLeft = pointingUp ? 4 : 3; //Asymmetric offsets to compensate for aliasing
                int baseOffsetRight = pointingUp ? 4 : 4;
                int baseOffsetHeight = pointingUp ? 2 : -2;
                int tipOffset = pointingUp ? -3 : 2; //Asymmetric offsets to compensate for aliasing
                return
                [
                    new Point(middle.X - baseOffsetLeft, middle.Y + baseOffsetHeight),
                    new Point(middle.X + baseOffsetRight, middle.Y + baseOffsetHeight),
                    new Point(middle.X, middle.Y + tipOffset)
                ];
            }
            protected override void WndProc(ref Message m)
            {
                var parentNumericUpdown = (M2TNumericUpDown)_updown.Parent!;
                if (m.Msg == 0xF /*WM_PAINT*/ && parentNumericUpdown.BorderStyle == BorderStyle.FixedSingle)
                {
                    var s = new PAINTSTRUCT();
                    IntBeginPaint(_updown.Handle, ref s);
                    using (var g = Graphics.FromHdc(s.hdc))
                    {
                        var enabled = _updown.Enabled;
                        using (var backBrush = new SolidBrush(enabled ? parentNumericUpdown.BackColor : SystemColors.Control))
                        {
                            g.FillRectangle(backBrush, _updown.ClientRectangle);
                        }
                        var upArrowBox = new Rectangle(0, 0, _updown.Width, _updown.Height / 2);
                        var downArrowBox = new Rectangle(0, _updown.Height / 2, _updown.Width, _updown.Height / 2 + 1);
                        var mousePosition = _updown.PointToClient(MousePosition);
                        bool mouseOnUpArrowBox = upArrowBox.Contains(mousePosition);
                        bool mouseOnDownArrowBox = downArrowBox.Contains(mousePosition);
                        bool mouseOnArrowBoxes = mouseOnUpArrowBox || mouseOnDownArrowBox;
                        if (enabled && mouseOnArrowBoxes)
                        {
                            using (var b = new SolidBrush(parentNumericUpdown.ForeColor))
                            {
                                if (mouseOnUpArrowBox)
                                    g.FillRectangle(b, upArrowBox);
                                if (mouseOnDownArrowBox)
                                    g.FillRectangle(b, downArrowBox);
                            }
                            using (var pen = new Pen(parentNumericUpdown.ForeColor))
                            {
                                IEnumerable<Point> lineVertical = [ new Point(0, 0), new Point(0, _updown.Height) ];
                                IEnumerable<Point> lineHorizontal = [ new Point(0, _updown.Height / 2), new Point(_updown.Width, _updown.Height / 2)];
                                var linesPoints = lineVertical.Concat(lineHorizontal);
                                g.DrawLines(pen, linesPoints.ToArray());
                            }
                        }
                        var upArrowColor = mouseOnUpArrowBox ? parentNumericUpdown.BackColor : parentNumericUpdown.ForeColor;
                        var downArrowColor = mouseOnDownArrowBox ? parentNumericUpdown.BackColor : parentNumericUpdown.ForeColor;
                        var upArrowBrush = new SolidBrush(upArrowColor);
                        var downArrowBrush = new SolidBrush(downArrowColor);
                        var upArrowPoints = GetArrowPoints(upArrowBox, true);
                        var downArrowPoints = GetArrowPoints(downArrowBox, false);
                        g.FillPolygon(upArrowBrush, upArrowPoints);
                        g.FillPolygon(downArrowBrush, downArrowPoints);
                    }
                    m.Result = 1;
                    base.WndProc(ref m);
                    IntEndPaint(_updown.Handle, ref s);
                }
                else if (m.Msg == 0x0014/*WM_ERASEBKGND*/)
                {
                    using (var g = Graphics.FromHdcInternal(m.WParam))
                        g.FillRectangle(Brushes.White, _updown.ClientRectangle);
                    m.Result = 1;
                }
                else
                    base.WndProc(ref m);
            }
        }
        #endregion FlatNumericUpDown
    }
}
