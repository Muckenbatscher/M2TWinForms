using M2TWinForms.Helper;
using M2TWinForms.Interfaces;
using M2TWinForms.Native;
using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace M2TWinForms.Controls.Window
{
    public partial class M2TForm : Form, IThemedControl
    {
        public event WindowIconClickedEventHandler WindowIconClicked;

        public delegate void WindowIconClickedEventHandler(object sender, EventArgs e);


        [DefaultValue(false)]
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

        private Point _originalTextLocation;
        [DefaultValue(true)]
        public bool HasIcon
        {
            get
            {
                return _hasIcon;
            }
            set
            {
                _hasIcon = value;
                int horizontalOffset = _hasIcon ? 0 : WindowImageButton.Width;
                LB_Title.Location = new Point(_originalTextLocation.X - horizontalOffset, _originalTextLocation.Y);
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

        [DefaultValue(typeof(Padding), "3, 3, 3, 3")]
        public Padding WindowIconPadding
        {
            get => WindowImageButton.ImagePadding;
            set => WindowImageButton.ImagePadding = value;
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

        [DefaultValue(true)]
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
                MinimizeBox = value;
            }
        }
        private bool _canMinimize = true;

        [DefaultValue(true)]
        public bool CanMaximize
        {
            get
            {
                return _canMaximize;
            }
            set
            {
                _canMaximize = value;
                MaximizeButton.Visible = value;
                MaximizeBox = value;
                RefreshMinizeButtonLocation();
            }
        }
        private bool _canMaximize = true;

        [DefaultValue(true)]
        public bool CanResize { get; set; } = true;

        [DefaultValue(true)]
        public bool CanHoverControlBox
        {
            get => _canHoverMaximizeClose;
            set
            {
                _canHoverMaximizeClose = value;
                MinimizeButton.HoverEnabled = value;
                MaximizeButton.HoverEnabled = value;
                CloseButton.HoverEnabled = value;
            }
        }
        private bool _canHoverMaximizeClose = true;

        [DefaultValue(FormBorderStyle.Sizable)]
        public new FormBorderStyle FormBorderStyle
        {
            get => _formBorderStyle;
            set
            {
                _formBorderStyle = value;
                IEnumerable<FormBorderStyle> resizableBorderStyles =
                [
                    FormBorderStyle.Sizable,
                    FormBorderStyle.SizableToolWindow
                ];
                CanResize = resizableBorderStyles.Contains(value);
                if (value == FormBorderStyle.None)
                   PN_DragPanel.Size = new Size(PN_DragPanel.Width, 0);
                else
                    PN_DragPanel.Size = new Size(PN_DragPanel.Width, 36);
            }
        }
        private FormBorderStyle _formBorderStyle;

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
            base.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            TitleBarForegroundColorRole = M2TFormForegroundRoleSelection.OnSurface;
            BackgroundColorRole = M2TFormBackgroundRoleSelection.Surface;
            TitleBarColorRole = M2TFormBackgroundRoleSelection.SurfaceContainerHigh;
            TitleBarButtonHoverColorRole = M2TFormBackgroundRoleSelection.SurfaceContainer;
            TitleBarForegroundColorRole = M2TFormForegroundRoleSelection.OnSurface;
            CloseButtonColorRole = M2TFormForegroundRoleSelection.Error;

            _originalTextLocation = LB_Title.Location;
            HasIcon = true;
            UseIconAsButton = false;
            WindowIconPadding = new Padding(3);

            base.Load += BaseWindowBorderless_Load;
            base.MouseMove += BaseWindowBorderless_MouseMove;
            PN_DragPanel.MouseMove += BaseWindowBorderless_MouseMove;
            base.MouseLeave += BaseWindowBorderless_MouseLeave;
            base.MouseDown += BaseWindowBorderless_MouseDown;

            PN_DragPanel.MouseDown += DraggingPanel_MouseDown;
            LB_Title.MouseDown += DraggingPanel_MouseDown;
            WindowImageButton.Click += WindowImageButton_Click;
            CloseButton.Click += CloseButton_Click;
            MaximizeButton.Click += MaximizeButton_Click;
            MinimizeButton.Click += MinimizeButton_Click;

            CanMinimize = true;
            CanMaximize = true;
            CanHoverControlBox = true;

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

        
        #region Drop Shadow
        private bool aeroEnabled;
        private void CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                NativeMethods.DwmIsCompositionEnabled(ref enabled);
                aeroEnabled = enabled == 1;
            }
            else
            {
                aeroEnabled = false;
            }
        }

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
                cp.Style = cp.Style | NativeConstants.WS_MINIMIZEBOX;
                if (!this.DesignMode)
                    cp.Style = cp.Style | NativeConstants.WS_THICKFRAME | NativeConstants.WS_CAPTION;

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

                    var margin = new NativeStructs.Margin();
                    margin.LeftWidth = 0;
                    margin.RightWidth = 0;
                    margin.TopHeight = 0;
                    margin.BottomHeight = 1;
                    NativeMethods.DwmExtendFrameIntoClientArea(Handle, ref margin);
                }
            }
            if (m.Msg == NativeConstants.WM_SYSCOMMAND)
            {
                var correctedWParam = m.WParam.ToInt32() & 0xFFF0;
                if (correctedWParam == NativeConstants.SC_MAXIMIZE || 
                    correctedWParam == NativeConstants.SC_RESTORE)
                {
                    SetCorrectedMaximizedBounds();
                }
            }
            else if (m.Msg == NativeConstants.WM_NCCALCSIZE)
            {
                m.Result = IntPtr.Zero;
                return;
            }
            base.WndProc(ref m);
        }

        #endregion


        #region Window Resizing
        private enum ResizeDirection
        {
            None,
            Left,
            TopLeft,
            Top,
            TopRight,
            Right,
            BottomRight,
            Bottom,
            BottomLeft
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

                this.Cursor = value switch
                {
                    ResizeDirection.Left or ResizeDirection.Right => Cursors.SizeWE,
                    ResizeDirection.Top or ResizeDirection.Bottom => Cursors.SizeNS,
                    ResizeDirection.BottomLeft or ResizeDirection.TopRight => Cursors.SizeNESW,
                    ResizeDirection.BottomRight or ResizeDirection.TopLeft => Cursors.SizeNWSE,
                    _ => Cursors.Default,
                };
            }
        }
        private ResizeDirection _resizeDir = ResizeDirection.None;


        private void BaseWindowBorderless_MouseLeave(object? sender, EventArgs e)
        {
            ResizeDir = ResizeDirection.None;
        }

        private void BaseWindowBorderless_MouseMove(object? sender, MouseEventArgs e)
        {
            RefreshResizeDirCursor(e.Location);
        }
        private void RefreshResizeDirCursor(Point mouseLocation)
        {
            if (!CanResize || this.WindowState != FormWindowState.Normal)
            {
                ResizeDir = ResizeDirection.None;
                return;
            }

            var borderWidthX = WindowBorderSystemMetrics.GetForX().Total;
            var borderWidthY = WindowBorderSystemMetrics.GetForY().Total;

            if (mouseLocation.X < borderWidthX & mouseLocation.Y < borderWidthY)
                ResizeDir = ResizeDirection.TopLeft;

            else if (mouseLocation.X < borderWidthX & mouseLocation.Y > this.Height - borderWidthY)
                ResizeDir = ResizeDirection.BottomLeft;

            else if (mouseLocation.X > this.Width - borderWidthX & mouseLocation.Y > this.Height - borderWidthY)
                ResizeDir = ResizeDirection.BottomRight;

            else if (mouseLocation.X > this.Width - borderWidthX & mouseLocation.Y < borderWidthY)
                ResizeDir = ResizeDirection.TopRight;

            else if (mouseLocation.X < borderWidthX)
                ResizeDir = ResizeDirection.Left;

            else if (mouseLocation.X > this.Width - borderWidthX)
                ResizeDir = ResizeDirection.Right;

            else if (mouseLocation.Y < borderWidthY)
                ResizeDir = ResizeDirection.Top;

            else if (mouseLocation.Y > this.Height - borderWidthY)
                ResizeDir = ResizeDirection.Bottom;

            else
                ResizeDir = ResizeDirection.None;
        }

        private void BaseWindowBorderless_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && CanResize && this.WindowState != FormWindowState.Maximized)
                ResizeForm(ResizeDir);
        }
        private void ResizeForm(ResizeDirection direction)
        {
            int dir = direction switch
            {
                ResizeDirection.Left => NativeConstants.HT_LEFT,
                ResizeDirection.TopLeft => NativeConstants.HT_TOPLEFT,
                ResizeDirection.Top => NativeConstants.HT_TOP,
                ResizeDirection.TopRight => NativeConstants.HT_TOPRIGHT,
                ResizeDirection.Right => NativeConstants.HT_RIGHT,
                ResizeDirection.BottomRight => NativeConstants.HT_BOTTOMRIGHT,
                ResizeDirection.Bottom => NativeConstants.HT_BOTTOM,
                ResizeDirection.BottomLeft => NativeConstants.HT_BOTTOMLEFT,
                _ => -1
            };

            if (dir != -1)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(this.Handle, NativeConstants.WM_NCLBUTTONDOWN, dir, 0);
            }
        }


        private void PerformMaximize()
        {
            if (this.WindowState == FormWindowState.Maximized)
                return;

            SetCorrectedMaximizedBounds();
            this.WindowState = FormWindowState.Maximized;
        }
        private void SetCorrectedMaximizedBounds()
        {
            var rect = Screen.FromHandle(this.Handle).WorkingArea;
            var correctedRect = new Rectangle(0, 0, rect.Width - 1, rect.Height + 1);
            this.MaximizedBounds = correctedRect;
        }
        #endregion


        #region Window Drag
        private void DraggingPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            //top window border resize
            if (ResizeDir != ResizeDirection.None && e.Button == MouseButtons.Left && CanResize && this.WindowState != FormWindowState.Maximized)
                ResizeForm(ResizeDir);

            else if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(this.Handle, NativeConstants.WM_NCLBUTTONDOWN, NativeConstants.HT_CAPTION, 0);
            }

            if (e.Button == MouseButtons.Left && e.Clicks == 2 && CanMaximize)
                RequestWindowStateMaximizationChange();
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
        private void MaximizeButton_Click(object? sender, EventArgs e)
        {
            RequestWindowStateMaximizationChange();
        }
        private void RequestWindowStateMaximizationChange()
        {
            if (this.WindowState == FormWindowState.Normal)
                PerformMaximize();
            else
                this.WindowState = FormWindowState.Normal;
        }

        private FormWindowState? _previousWindowState;
        private void M2TForm_Resize(object sender, EventArgs e)
        {
            var currentWindowState = this.WindowState;
            if (_previousWindowState != null && _previousWindowState != currentWindowState)
            {
                RefreshMaximizeButtonForWindowState();
            }
            _previousWindowState = currentWindowState;
            RefreshMinizeButtonLocation();
        }
        private void RefreshMaximizeButtonForWindowState()
        {
            bool isMaximized = WindowState == FormWindowState.Maximized;
            MaximizeButton.BaseImage = isMaximized ? Properties.Resources.Window : Properties.Resources.Maximize;
        }
        private void RefreshMinizeButtonLocation()
        {
            var minimizeOffset = CloseButton.Width + (CanMaximize ? MaximizeButton.Width : 0) + MinimizeButton.Width + PN_DragPanel.Padding.Right + PN_DragPanel.Padding.Left;
            MinimizeButton.Location = new Point(PN_DragPanel.Width - minimizeOffset, MinimizeButton.Location.Y);
        }
        #endregion

    }
}
