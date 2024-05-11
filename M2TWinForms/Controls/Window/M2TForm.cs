using M2TWinForms.Enumerations;
using M2TWinForms.Helper;
using M2TWinForms.Interfaces;
using M2TWinForms.Services;
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

        public bool HasImage
        {
            get
            {
                return _hasImage;
            }
            set
            {
                _hasImage = value;
                LB_Title.Location = new Point(originalTextLocation.X - (_hasImage ? 0 : WindowImageButton.Width), originalTextLocation.Y);
                WindowImageButton.Visible = value;
            }
        }
        private bool _hasImage = true;

        public Image WindowIcon
        {
            get
            {
                return _windowIcon;
            }
            set
            {
                _windowIcon = value;
                HasImage = HasImage && !(value == null);
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

        public ColorType BackColorType
        {
            get => backColorType;
            set
            {
                backColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType backColorType = ColorType.BackgroundPrimary;
        public ColorType TitleBarBackColorType
        {
            get => titleBarBackColorType;
            set
            {
                titleBarBackColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType titleBarBackColorType = ColorType.BackgroundSecondary;
        public ColorType TitleBarTextColorType
        {
            get => titleBarTextColorType;
            set
            {
                titleBarTextColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType titleBarTextColorType = ColorType.ForegroundPrimary;
        public ColorType TitleBarIconImageColorType
        {
            get => WindowImageButton.ImageColorType;
            set
            {
                WindowImageButton.ImageColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarIconHoverImageColorType
        {
            get => WindowImageButton.HoverImageColorType;
            set
            {
                WindowImageButton.HoverImageColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarIconBackColorType
        {
            get => WindowImageButton.BackgroundColorType;
            set
            {
                WindowImageButton.BackgroundColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarIconHoverBackColorType
        {
            get => WindowImageButton.HoverBackgroundColorType;
            set
            {
                WindowImageButton.HoverBackgroundColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }

        public ColorType TitleBarMinimizeImageColorType
        {
            get => MinimizeButton.ImageColorType;
            set
            {
                MinimizeButton.ImageColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarMinimizeHoverImageColorType
        {
            get => MinimizeButton.HoverImageColorType;
            set
            {
                MinimizeButton.HoverImageColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarMinimizeBackColorType
        {
            get => MinimizeButton.BackgroundColorType;
            set
            {
                MinimizeButton.BackgroundColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarMinimizeHoverBackColorType
        {
            get => MinimizeButton.HoverBackgroundColorType;
            set
            {
                MinimizeButton.HoverBackgroundColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarCloseImageColorType
        {
            get => CloseButton.ImageColorType;
            set
            {
                CloseButton.ImageColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarCloseHoverImageColorType
        {
            get => CloseButton.HoverImageColorType;
            set
            {
                CloseButton.HoverImageColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarCloseBackColorType
        {
            get => CloseButton.BackgroundColorType;
            set
            {
                CloseButton.BackgroundColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        public ColorType TitleBarCloseHoverBackColorType
        {
            get => CloseButton.HoverBackgroundColorType;
            set
            {
                CloseButton.HoverBackgroundColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }

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

            TitleBarIconImageColorType = ColorType.HighlightForegroundPrimary;
            TitleBarIconHoverImageColorType = ColorType.HighlightHoverForegroundPrimary;
            TitleBarIconBackColorType = ColorType.BackgroundSecondary;
            TitleBarIconHoverBackColorType = ColorType.BackgroundHoverSecondary;
            TitleBarMinimizeImageColorType = ColorType.ForegroundPrimary;
            TitleBarMinimizeHoverImageColorType = ColorType.ForegroundHoverPrimary;
            TitleBarMinimizeBackColorType = ColorType.BackgroundSecondary;
            TitleBarMinimizeHoverBackColorType = ColorType.BackgroundHoverSecondary;
            TitleBarCloseImageColorType = ColorType.NegativeConfirmationBackground;
            TitleBarCloseHoverImageColorType = ColorType.NegativeConfirmationHoverBackground;
            TitleBarCloseBackColorType = ColorType.BackgroundSecondary;
            TitleBarCloseHoverBackColorType = ColorType.BackgroundHoverSecondary;

            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            this.BackColor = CurrentLoadedThemeManager.GetColorForType(BackColorType);
            PN_DragPanel.BackColor = CurrentLoadedThemeManager.GetColorForType(TitleBarBackColorType);
            LB_Title.ForeColor = CurrentLoadedThemeManager.GetColorForType(TitleBarTextColorType);

            NestedControlThemeApplier.ApplyThemeForChildControls(this);
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

        public partial class NativeMethods
        {
            [DllImport("dwmapi")]
            public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref NativeStructs.MARGINS pMarInset);
            [DllImport("dwmapi")]
            internal static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
            [DllImport("dwmapi.dll")]
            public static extern int DwmIsCompositionEnabled(ref int pfEnabled);
        }
        public partial class NativeConstants
        {
            public const int CS_DROPSHADOW = 0x20000;
            public const int WM_NCPAINT = 0x85;
        }


        #region Drop Shadow

        public partial class NativeStructs
        {
            public partial struct MARGINS
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
                if (!aeroEnabled)
                {
                    cp.ClassStyle = cp.ClassStyle | NativeConstants.CS_DROPSHADOW;
                    return cp;
                }
                else
                {
                    return cp;
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case NativeConstants.WM_NCPAINT:
                    {
                        int val = 2;
                        if (aeroEnabled)
                        {
                            NativeMethods.DwmSetWindowAttribute(Handle, 2, ref val, 4);
                            var mrg = new NativeStructs.MARGINS();
                            mrg.leftWidth = 0;
                            mrg.rightWidth = 0;
                            mrg.topHeight = 0;
                            mrg.bottomHeight = 1;
                            NativeMethods.DwmExtendFrameIntoClientArea(Handle, ref mrg);
                        }
                        break;
                    }
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

        private void WindowImageButton_Click(object sender, EventArgs e)
        {
            if (UseIconAsButton)
            {
                WindowIconClicked?.Invoke(this, new EventArgs());
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #endregion

    }
}
