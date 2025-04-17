using M2TWinForms.Enumerations;
using M2TWinForms.Helper;
using M2TWinForms.Interfaces;
using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace M2TWinForms.Controls.Window
{
    public partial class M2TForm : Form, IThemedControl
    {
        public event WindowIconClickedEventHandler WindowIconClicked;

        public delegate void WindowIconClickedEventHandler(object sender, EventArgs e);


        private Point originalTextLocation;

        public bool UseIconAsButton
        {
            get
            {
                return WindowImageButton.HoverEnabled;
            }
            set
            {
                WindowImageButton.HoverEnabled = value;
            }
        }

        public bool HasIcon
        {
            get
            {
                return _hasIcon;
            }
            set
            {
                _hasIcon = value;
                LB_Title.Location = new Point(originalTextLocation.X - (_hasIcon ? 0 : WindowImageButton.Width), originalTextLocation.Y);
                WindowImageButton.Visible = value;
            }
        }
        private bool _hasIcon = true;

        public Image WindowIcon
        {
            get
            {
                return _windowIcon;
            }
            set
            {
                _windowIcon = value;
                HasIcon = HasIcon && !(value == null);
                WindowImageButton.BaseImage = value;
            }
        }
        private Image _windowIcon;

        public Padding WindowIconPadding
        {
            get
            {
                return WindowImageButton.ImagePadding;
            }
            set
            {
                WindowImageButton.ImagePadding = value;
            }
        }

        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                LB_Title.Text = value;
                base.Text = value;
            }
        }

        public bool CanMinimize
        {
            get
            {
                return _canMinimize;
            }
            set
            {
                _canMinimize = value;
                MinimizeButton.Visible = value;
            }
        }
        private bool _canMinimize = true;

        public bool CanResize { get; set; } = true;

        public bool CanHoverMinimizeClose
        {
            get => _canHoverMaximizeClose;
            set
            {
                _canHoverMaximizeClose = value;
                MinimizeButton.HoverEnabled = value;
                CloseButton.HoverEnabled = value;
            }
        }
        private bool _canHoverMaximizeClose;


        [Description("The Material Design Color Role used for background of the form")]
        [Category("Material Design")]
        public M2TFormBackgroundRoleSelection BackgroundColorRole
        {
            get => _backgroundColorRole;
            set
            {
                _backgroundColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormBackgroundRoleSelection _backgroundColorRole = M2TFormBackgroundRoleSelection.Surface;

        [Description("The Material Design Color Role used for titlebar of the form containing the control buttons")]
        [Category("Material Design")]
        public M2TFormBackgroundRoleSelection TitleBarColorRole
        {
            get => _titleBarColorRole;
            set
            {
                _titleBarColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormBackgroundRoleSelection _titleBarColorRole = M2TFormBackgroundRoleSelection.SurfaceContainerHigh;

        [Description("The Material Design Color Role used for the hover color of the control buttons in the titlebar")]
        [Category("Material Design")]
        public M2TFormBackgroundRoleSelection TitleBarButtonHoverColorRole
        {
            get => _titleBarButtonHoverColorRole;
            set
            {
                _titleBarButtonHoverColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormBackgroundRoleSelection _titleBarButtonHoverColorRole = M2TFormBackgroundRoleSelection.SurfaceContainer;

        [Description("The Material Design Color Role used for the foreground color of the control buttons and window title text in the titlebar")]
        [Category("Material Design")]
        public M2TFormForegroundRoleSelection TitleBarForegroundColorRole
        {
            get => _titleBarForegroundColorRole;
            set
            {
                _titleBarForegroundColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormForegroundRoleSelection _titleBarForegroundColorRole = M2TFormForegroundRoleSelection.OnSurface;

        [Description("The Material Design Color Role used for the foreground color of the close button in the titlebar")]
        [Category("Material Design")]
        public M2TFormForegroundRoleSelection CloseButtonColorRole
        {
            get => _closeButtonColorRole;
            set
            {
                _closeButtonColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private M2TFormForegroundRoleSelection _closeButtonColorRole = M2TFormForegroundRoleSelection.Error;

        public M2TForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            WindowIconPadding = new Padding(3);
            UseIconAsButton = false;

            originalTextLocation = LB_Title.Location;

            base.Load += BaseWindowBorderless_Load;
            base.MouseMove += BaseWindowBorderless_MouseMove;
            base.MouseLeave += BaseWindowBorderless_MouseLeave;
            base.MouseDown += BaseWindowBorderless_MouseDown;

            PN_DragPanel.MouseDown += DraggingPanel_MouseDown;
            LB_Title.MouseDown += DraggingPanel_MouseDown;
            WindowImageButton.Click += WindowImageButton_Click;
            CloseButton.Click += CloseButton_Click;
            MinimizeButton.Click += MinimizeButton_Click;

            CanHoverMinimizeClose = true;

            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            this.BackColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(BackgroundColorRole));
            PN_DragPanel.BackColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(TitleBarColorRole));
            LB_Title.ForeColor = CurrentLoadedThemeManager.GetColorForRole(GetMappedRole(TitleBarForegroundColorRole));

            WindowImageButton.ImageColorRole = GetMappedRole(TitleBarForegroundColorRole);
            MinimizeButton.ImageColorRole = GetMappedRole(TitleBarForegroundColorRole);
            CloseButton.ImageColorRole = GetMappedRole(CloseButtonColorRole);
            WindowImageButton.HoverBackgroundColorRole = GetMappedRole(TitleBarButtonHoverColorRole);
            MinimizeButton.HoverBackgroundColorRole = GetMappedRole(TitleBarButtonHoverColorRole);
            CloseButton.HoverBackgroundColorRole = GetMappedRole(TitleBarButtonHoverColorRole);

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


        private void BaseWindowBorderless_Load(object? sender, EventArgs e)
        {
            CenterToParent();
        }


        #region Borderless Window

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public class NativeMethods
        {
            [DllImport("dwmapi")]
            public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref NativeStructs.MARGINS pMarInset);
            [DllImport("dwmapi")]
            internal static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
            [DllImport("dwmapi.dll")]
            public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        }
        public class NativeConstants
        {
            public const int CS_DROPSHADOW = 0x20000;
            public const int WM_NCPAINT = 0x85;
            public const int WS_MINIMIZEBOX = 0x20000;
            public const int CS_DBLCLKS = 0x8;
            public const int WS_THICKFRAME = 0x40000;
            public const int WS_CAPTION = 0xC00000;
            public const int WM_NCCALCSIZE = 0x0083;
        }


        #region Drop Shadow

        public class NativeStructs
        {
            public struct MARGINS
            {
                public int leftWidth;
                public int rightWidth;
                public int topHeight;
                public int bottomHeight;
            }
        }

        private bool aeroEnabled;
        protected override CreateParams CreateParams
        {
            get
            {
                CheckAeroEnabled();
                CreateParams cp = base.CreateParams;
                //drop shadow
                if (!aeroEnabled)
                    cp.ClassStyle = cp.ClassStyle | NativeConstants.CS_DROPSHADOW;

                //minimize from taskbar
                cp.Style = cp.Style | NativeConstants.WS_MINIMIZEBOX | NativeConstants.WS_THICKFRAME | NativeConstants.WS_CAPTION;
                cp.ClassStyle = cp.ClassStyle | NativeConstants.CS_DBLCLKS;

                return cp;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeConstants.WM_NCPAINT)
            {
                if (aeroEnabled)
                {
                    int val = 2;
                    NativeMethods.DwmSetWindowAttribute(Handle, 2, ref val, 4);
                    var margin = new NativeStructs.MARGINS();
                    margin.leftWidth = 0;
                    margin.rightWidth = 0;
                    margin.topHeight = 0;
                    margin.bottomHeight = 1;
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, ref margin);
                }
            }
            else if (m.Msg == NativeConstants.WM_NCCALCSIZE)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
        }
        private void CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                int response = NativeMethods.DwmIsCompositionEnabled(ref enabled);
                aeroEnabled = enabled == 1;
            }
            else
            {
                aeroEnabled = false;
            }
        }

        #endregion


        #region Window Resizing

        private const int HTBOTTOM = 15;
        private const int HTBOTTOMLEFT = 16;
        private const int HTBOTTOMRIGHT = 17;
        private const int HTCAPTION = 2;
        private const int HTLEFT = 10;
        private const int HTRIGHT = 11;
        private const int HTTOP = 12;
        private const int HTTOPLEFT = 13;
        private const int HTTOPRIGHT = 14;

        private const int BorderWidth = 8;
        private ResizeDirection _resizeDir = ResizeDirection.None;

        private enum ResizeDirection
        {
            None = 0,
            Left = 1,
            TopLeft = 2,
            Top = 3,
            TopRight = 4,
            Right = 5,
            BottomRight = 6,
            Bottom = 7,
            BottomLeft = 8
        }

        private ResizeDirection ResizeDir
        {
            get
            {
                return _resizeDir;
            }
            set
            {
                _resizeDir = value;

                // Change cursor
                switch (value)
                {
                    case ResizeDirection.Left:
                    case ResizeDirection.Right:
                        {
                            this.Cursor = Cursors.SizeWE;
                            break;
                        }

                    case ResizeDirection.Top:
                    case ResizeDirection.Bottom:
                        {
                            this.Cursor = Cursors.SizeNS;
                            break;
                        }

                    case ResizeDirection.BottomLeft:
                    case ResizeDirection.TopRight:
                        {
                            this.Cursor = Cursors.SizeNESW;
                            break;
                        }

                    case ResizeDirection.BottomRight:
                    case ResizeDirection.TopLeft:
                        {
                            this.Cursor = Cursors.SizeNWSE;
                            break;
                        }

                    default:
                        {
                            this.Cursor = Cursors.Default;
                            break;
                        }
                }
            }
        }


        private void BaseWindowBorderless_MouseMove(object? sender, MouseEventArgs e)
        {
            if (!CanResize)
            {
                ResizeDir = ResizeDirection.None;
                return;
            }

            if (e.Location.X < BorderWidth & e.Location.Y < BorderWidth)
            {
                ResizeDir = ResizeDirection.TopLeft;
            }

            else if (e.Location.X < BorderWidth & e.Location.Y > this.Height - BorderWidth)
            {
                ResizeDir = ResizeDirection.BottomLeft;
            }

            else if (e.Location.X > this.Width - BorderWidth & e.Location.Y > this.Height - BorderWidth)
            {
                ResizeDir = ResizeDirection.BottomRight;
            }

            else if (e.Location.X > this.Width - BorderWidth & e.Location.Y < BorderWidth)
            {
                ResizeDir = ResizeDirection.TopRight;
            }

            else if (e.Location.X < BorderWidth)
            {
                ResizeDir = ResizeDirection.Left;
            }

            else if (e.Location.X > this.Width - BorderWidth)
            {
                ResizeDir = ResizeDirection.Right;
            }

            else if (e.Location.Y < BorderWidth)
            {
                ResizeDir = ResizeDirection.Top;
            }

            else if (e.Location.Y > this.Height - BorderWidth)
            {
                ResizeDir = ResizeDirection.Bottom;
            }

            else
            {
                ResizeDir = ResizeDirection.None;
            }
        }

        private void BaseWindowBorderless_MouseLeave(object? sender, EventArgs e)
        {
            ResizeDir = ResizeDirection.None;
        }


        private void BaseWindowBorderless_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && this.WindowState != FormWindowState.Maximized)
            {
                ResizeForm(ResizeDir);
            }
        }
        private void ResizeForm(ResizeDirection direction)
        {
            int dir = -1;
            switch (direction)
            {
                case ResizeDirection.Left:
                    {
                        dir = HTLEFT;
                        break;
                    }
                case ResizeDirection.TopLeft:
                    {
                        dir = HTTOPLEFT;
                        break;
                    }
                case ResizeDirection.Top:
                    {
                        dir = HTTOP;
                        break;
                    }
                case ResizeDirection.TopRight:
                    {
                        dir = HTTOPRIGHT;
                        break;
                    }
                case ResizeDirection.Right:
                    {
                        dir = HTRIGHT;
                        break;
                    }
                case ResizeDirection.BottomRight:
                    {
                        dir = HTBOTTOMRIGHT;
                        break;
                    }
                case ResizeDirection.Bottom:
                    {
                        dir = HTBOTTOM;
                        break;
                    }
                case ResizeDirection.BottomLeft:
                    {
                        dir = HTBOTTOMLEFT;
                        break;
                    }
            }

            if (dir != -1)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, dir, 0);
            }
        }


        #endregion


        #region Window Drag
        private void DraggingPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        #endregion


        #endregion


        #region ControlButtons

        private void WindowImageButton_Click(object? sender, EventArgs e)
        {
            if (UseIconAsButton)
            {
                WindowIconClicked?.Invoke(this, new EventArgs());
            }
        }

        private void CloseButton_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MinimizeButton_Click(object? sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

    }
}
