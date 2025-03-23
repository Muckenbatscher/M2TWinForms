using M2TWinForms.Enumerations;
using M2TWinForms.Interfaces;
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

namespace M2TWinForms.Controls.Inputs.Text
{
    public partial class M2TRichTextBox : RichTextBox, IThemedControl
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
            get => _foreColor;
            set
            {
                _foreColor = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _foreColor = ColorType.ForegroundPrimary;

        [DefaultValue(ColorType.HighlightBackgroundPrimary)]
        public ColorType HighlightBackColorType
        {
            get => _highlightBackColorType;
            set
            {
                _highlightBackColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _highlightBackColorType = ColorType.HighlightBackgroundPrimary;

        [DefaultValue(ColorType.HighlightForegroundPrimary)]
        public ColorType HighlightForeColorType
        {
            get => _highlightForeColorType;
            set
            {
                _highlightForeColorType = value;
                ApplyCurrentLoadedTheme();
            }
        }
        private ColorType _highlightForeColorType = ColorType.HighlightForegroundPrimary;

        public M2TRichTextBox()
        {
            InitializeComponent();
            ApplyCurrentLoadedTheme();
        }

        public void ApplyCurrentLoadedTheme()
        {
            this.BackColor = CurrentLoadedThemeManager.GetColorForType(BackColorType);
            this.ForeColor = CurrentLoadedThemeManager.GetColorForType(ForeColorType);
            
        }

        private void M2TRichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            ApplySelectionColor();
        }

        private void ApplySelectionColor()
        {
            this.SelectionColor = CurrentLoadedThemeManager.GetColorForType(ForeColorType);
            this.SelectionBackColor = CurrentLoadedThemeManager.GetColorForType(BackColorType);
            this.SelectionColor = CurrentLoadedThemeManager.GetColorForType(HighlightForeColorType);
            //this.SelectionBackColor = CurrentLoadedThemeManager.GetColorForType(HighlightBackColorType);
        }
    }
}
