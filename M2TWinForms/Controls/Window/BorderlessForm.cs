using M2TWinForms.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms
{
    public partial class BorderlessForm : Form
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

        [DefaultValue(true)]
        public bool CanResize
        {
            get
            {
                IEnumerable<FormBorderStyle> resizableBorderStyles =
                [
                    FormBorderStyle.Sizable,
                    FormBorderStyle.SizableToolWindow
                ];
                bool resizableBorderStyle = resizableBorderStyles.Contains(FormBorderStyle);
                bool resizableSizeGripStyle = SizeGripStyle == SizeGripStyle.Show;
                return resizableBorderStyle && resizableSizeGripStyle;
            }
        }

        [DefaultValue(FormBorderStyle.Sizable)]
        public new FormBorderStyle FormBorderStyle
        {
            get => _formBorderStyle;
            set
            {
                _formBorderStyle = value;
                if (value == FormBorderStyle.None)
                    PN_DragPanel.Size = new Size(PN_DragPanel.Width, 0);
                else
                    PN_DragPanel.Size = new Size(PN_DragPanel.Width, 36);
            }
        }
        private FormBorderStyle _formBorderStyle;

        [DefaultValue(SizeGripStyle.Show)]
        public new SizeGripStyle SizeGripStyle
        {
            get => _sizeGripStyle;
            set
            {
                _sizeGripStyle = value;
                base.SizeGripStyle = value;
            }
        }
        private SizeGripStyle _sizeGripStyle;


        public Color TitleBarColor
        {
            get => PN_DragPanel.BackColor;
            set => PN_DragPanel.BackColor = value;
        }

        public Color TitleBarButtonHoverColor
        {
            get => WindowImageButton.HoverBackColor;
            set
            {
                WindowImageButton.HoverBackColor = value;
                MinimizeButton.HoverBackColor = value;
                MaximizeButton.HoverBackColor = value;
                CloseButton.HoverBackColor = value;
            }
        }

        public Color TitleBarForegroundColor
        {
            get => LB_Title.ForeColor;
            set
            {
                LB_Title.ForeColor = value;
                WindowImageButton.ImageColor = value;
                MinimizeButton.ImageColor = value;
                MaximizeButton.ImageColor = value;
                WindowImageButton.HoverImageColor = value;
                MinimizeButton.HoverImageColor = value;
                MaximizeButton.HoverImageColor = value;
            }
        }

        public Color CloseButtonColor
        {
            get => CloseButton.ImageColor;
            set
            {
                CloseButton.ImageColor = value;
                CloseButton.HoverImageColor = value;
            }
        }


        public BorderlessForm()
        {
            InitializeComponent();
            base.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            TitleBarForegroundColor = SystemColors.ControlText;
            BackColor = SystemColors.Window;
            TitleBarColor = SystemColors.Control;
            TitleBarButtonHoverColor = SystemColors.ControlDark;
            CloseButtonColor = Color.Firebrick;

            _originalTextLocation = LB_Title.Location;
            HasIcon = true;
            SizeGripStyle = SizeGripStyle.Show;
            UseIconAsButton = false;
            WindowIconPadding = new Padding(3);

            base.Load += BaseWindowBorderless_Load;
            base.Resize += BorderlessForm_Resize;
            AttachMouseResizeHandlersRecursively(this);

            PN_DragPanel.MouseDown += DraggingPanel_MouseDown;
            LB_Title.MouseDown += DraggingPanel_MouseDown;
            WindowImageButton.Click += WindowImageButton_Click;
            CloseButton.Click += CloseButton_Click;
            MaximizeButton.Click += MaximizeButton_Click;
            MinimizeButton.Click += MinimizeButton_Click;

            CanMinimize = true;
            CanMaximize = true;
            CanHoverControlBox = true;
        }


        private void BaseWindowBorderless_Load(object? sender, EventArgs e)
        {
            CenterToParent();
        }


        #region Borderless Window


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeConstants.WM_NCPAINT)
            {
                if (aeroEnabled)
                {
                    int DWMNCRP_DISABLED = 2;
                    int DWMWA_NCRENDERING_POLICY = 2;
                    NativeMethods.DwmSetWindowAttribute(Handle, DWMWA_NCRENDERING_POLICY, ref DWMNCRP_DISABLED, 4);

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
            RefreshResizeDirCursor();
        }
        private void BaseWindowBorderless_MouseMove(object? sender, MouseEventArgs e)
        {
            RefreshResizeDirCursor();
        }
        private void RefreshResizeDirCursor()
        {
            if (!CanResize || this.WindowState != FormWindowState.Normal)
            {
                ResizeDir = ResizeDirection.None;
                return;
            }

            Point mouseLocation = PointToClient(Cursor.Position);

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

        private void BorderlessForm_ControlAdded(object? sender, ControlEventArgs e)
        {
            if (e.Control == null)
                return;
            AttachMouseResizeHandlersRecursively(e.Control);
        }
        private void BorderlessForm_ControlRemoved(object? sender, ControlEventArgs e)
        {
            if (e.Control == null)
                return;
            DetachMouseResizeHandlersRecursively(e.Control);
        }
        private void AttachMouseResizeHandlersRecursively(Control control)
        {
            control.MouseMove += BaseWindowBorderless_MouseMove;
            control.MouseLeave += BaseWindowBorderless_MouseLeave;
            control.MouseDown += BaseWindowBorderless_MouseDown;
            foreach (Control child in control.Controls)
            {
                AttachMouseResizeHandlersRecursively(child);
            }
            control.ControlAdded += BorderlessForm_ControlAdded;
            control.ControlRemoved += BorderlessForm_ControlRemoved;
        }
        private void DetachMouseResizeHandlersRecursively(Control control)
        {
            control.MouseMove -= BaseWindowBorderless_MouseMove;
            control.MouseLeave -= BaseWindowBorderless_MouseLeave;
            control.MouseDown -= BaseWindowBorderless_MouseDown;
            foreach (Control child in control.Controls)
            {
                DetachMouseResizeHandlersRecursively(child);
            }
            control.ControlAdded -= BorderlessForm_ControlAdded;
            control.ControlRemoved -= BorderlessForm_ControlRemoved;
        }
        #endregion


        #region Window Drag
        private void DraggingPanel_MouseDown(object? sender, MouseEventArgs e)
        {
            //top window border resize
            if (ResizeDir != ResizeDirection.None && e.Button == MouseButtons.Left && CanResize && this.WindowState != FormWindowState.Maximized)
                return; //handled by other method for this event

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

        private FormWindowState? _previousWindowState;
        private void BorderlessForm_Resize(object? sender, EventArgs e)
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
