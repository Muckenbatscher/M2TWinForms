using M2TWinForms.Themes.MaterialDesign;
using M2TWinForms.Themes.ThemeLoading;
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
    public partial class M2TColoredImageButton : ColoredImageButton, IThemedControl
    {
        
        public ColorRoles ImageColorRole
        {
            get => _imageColorRole;
            set
            {
                _imageColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorRoles _imageColorRole = ColorRoles.OnSurface;
        

        public ColorRoles HoverImageColorRole
        {
            get => _hoverImageColorRole;
            set
            {
                _hoverImageColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorRoles _hoverImageColorRole = ColorRoles.OnSurface;
        

        public ColorRoles BackgroundColorRole
        {
            get => _backgroundColorRole;
            set
            {
                _backgroundColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorRoles _backgroundColorRole = ColorRoles.Surface;
        

        public ColorRoles HoverBackgroundColorRole
        {
            get => _hoverBackgroundColorRole;
            set
            {
                _hoverBackgroundColorRole = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorRoles _hoverBackgroundColorRole = ColorRoles.SurfaceContainer;



        public M2TColoredImageButton()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        public void ApplyCurrentLoadedTheme()
        {
            ImageColor = CurrentLoadedThemeManager.GetColorForRole(ImageColorRole);
            HoverImageColor = CurrentLoadedThemeManager.GetColorForRole(HoverImageColorRole);
            BackColor = CurrentLoadedThemeManager.GetColorForRole(BackgroundColorRole);
            HoverBackColor = CurrentLoadedThemeManager.GetColorForRole(HoverBackgroundColorRole);
        }
    }
}
