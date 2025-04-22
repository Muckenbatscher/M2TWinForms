using M2TWinForms.Helper;
using M2TWinForms.Themes.MaterialDesign;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.Controls.Inputs.Buttons
{
    public partial class ColoredImageButton : UserControl
    {
        public Image? BaseImage
        {
            get
            {
                return _baseImage;
            }
            set
            {
                _baseImage = value;
                ConvertedBaseImage = value;
            }
        }
        private Image? _baseImage;

        private Image? ConvertedBaseImage
        {
            get
            {
                return _convertedBaseImage;
            }
            set
            {
                if (!(value == null) && ConvertBaseImageToGrayscale)
                {
                    _convertedBaseImage = ImageMethods.GetGrayScaledImage(value);
                }
                else
                {
                    _convertedBaseImage = value;
                }
                ForceImageRedraw();
            }
        }
        private Image? _convertedBaseImage;

        public bool ConvertBaseImageToGrayscale
        {
            get
            {
                return _convertBaseImageToGrayscale;
            }
            set
            {
                bool previousValue = _convertBaseImageToGrayscale;
                _convertBaseImageToGrayscale = value;
                if (!previousValue && value) // previously false, now true
                {
                    _convertedBaseImage = BaseImage;
                }
            }
        }
        private bool _convertBaseImageToGrayscale;


        public Padding ImagePadding
        {
            get
            {
                return _imagePadding;
            }
            set
            {
                _imagePadding = value;
                ForceImageRedraw();
            }
        }
        private Padding _imagePadding;


        public Color ImageColor
        {
            get
            {
                return _imageColor;
            }
            set
            {
                _imageColor = value;
                ForceImageRedraw();
            }
        }
        private Color _imageColor;


        public Color HoverImageColor
        {
            get
            {
                return _hoverImageColor;
            }
            set
            {
                _hoverImageColor = value;
                ForceImageRedraw();
            }
        }
        private Color _hoverImageColor;


        public new Color BackColor
        {
            get
            {
                return _originalBackColor;
            }
            set
            {
                _originalBackColor = value;
                base.BackColor = value;
            }
        }
        private Color _originalBackColor;


        public Color HoverBackColor { get; set; }
        public bool HoverEnabled
        {
            get
            {
                return _hoverEnabled;
            }
            set
            {
                _hoverEnabled = value;
                if (!value)
                    IsCurrentlyHovered = false;
            }
        }
        private bool _hoverEnabled;

        private bool IsCurrentlyHovered
        {
            get => _isCurrentlyHovered;
            set
            {
                _isCurrentlyHovered = value;
                base.BackColor = value ? HoverBackColor : BackColor;
            }
        }
        private bool _isCurrentlyHovered;

        public new event ClickEventHandler? Click;

        public delegate void ClickEventHandler(object? sender, EventArgs e);

        public ColoredImageButton()
        {
            InitializeComponent();
            DoubleBuffered = true;

            base.Click += ColoredImageButton_Click;
            base.Load += ColoredImageButton_Load;
            base.Paint += ColoredImageButton_Paint;
            base.MouseEnter += ColoredImageButton_MouseEnter;
            base.MouseLeave += ColoredImageButton_MouseLeave;
        }

        private void ColoredImageButton_Click(object? sender, EventArgs e)
        {
            Click?.Invoke(this, new EventArgs());
        }

        private void ColoredImageButton_Load(object? sender, EventArgs e)
        {
            ForceImageRedraw();
        }

        private void ForceImageRedraw()
        {
            this.Refresh();
        }
        private void ColoredImageButton_Paint(object? sender, PaintEventArgs e)
        {
            Color imageColor = IsCurrentlyHovered ? HoverImageColor : ImageColor;
            ImageMethods.DrawImageWithColor(ConvertedBaseImage, imageColor, ImagePadding, this, e);
        }

        private void ColoredImageButton_MouseEnter(object? sender, EventArgs e)
        {
            if (HoverEnabled)
                IsCurrentlyHovered = true;
        }
        private void ColoredImageButton_MouseLeave(object? sender, EventArgs e)
        {
            IsCurrentlyHovered = false;
        }
    }
}
