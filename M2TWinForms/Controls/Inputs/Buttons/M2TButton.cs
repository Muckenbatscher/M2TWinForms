using M2TWinForms.Enumerations;
using M2TWinForms.Interfaces;
using M2TWinForms.Models;
using M2TWinForms.Services;
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
    public partial class M2TButton : Button, IThemedControl
    {
        [DefaultValue(ColorType.BackgroundSecondary)]
        public ColorType BackColorType
        {
            get => _backColorType;
            set
            {
                _backColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _backColorType = ColorType.BackgroundSecondary;

        [DefaultValue(ColorType.ForegroundPrimary)]
        public ColorType ForeColorType 
        { 
            get => _foreColorType;
            set
            {
                _foreColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _foreColorType = ColorType.ForegroundPrimary;

        [DefaultValue(ColorType.BackgroundHoverSecondary)]
        public ColorType HoverBackColorType
        {
            get => _hoverBackColorType;
            set
            {
                _hoverBackColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _hoverBackColorType = ColorType.BackgroundHoverSecondary;

        [DefaultValue(ColorType.ForegroundHoverPrimary)]
        public ColorType HoverForeColorType
        {
            get => _hoverForeColorType;
            set
            {
                _hoverForeColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _hoverForeColorType = ColorType.ForegroundHoverPrimary;
        public M2TButton()
        {
            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            this.BackColor = CurrentLoadedThemeManager.GetColorForType(BackColorType);
            this.ForeColor = CurrentLoadedThemeManager.GetColorForType(ForeColorType);
            this.FlatAppearance.BorderColor = CurrentLoadedThemeManager.GetColorForType(ForeColorType);
            this.FlatAppearance.MouseOverBackColor = CurrentLoadedThemeManager.GetColorForType(HoverBackColorType);
        }

    }
}
