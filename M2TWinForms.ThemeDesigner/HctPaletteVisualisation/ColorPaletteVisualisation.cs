using M2TWinForms.Themes.Creation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.ThemeDesigner.HctPaletteVisualisation
{
    public partial class ColorPaletteVisualisation : UserControl
    {
        public ColorPaletteVisualisation()
        {
            InitializeComponent();
        }

        public Color ZeroColor { get => CSV_Zero.StepColor; private set => CSV_Zero.StepColor = value; }
        public Color TenColor { get => CSV_Ten.StepColor; private set => CSV_Ten.StepColor = value; }
        public Color TwentyColor { get => CSV_Twenty.StepColor; private set => CSV_Twenty.StepColor = value; }
        public Color ThirtyColor { get => CSV_Thirty.StepColor; private set => CSV_Thirty.StepColor = value; }
        public Color FortyColor { get => CSV_Forty.StepColor; private set => CSV_Forty.StepColor = value; }
        public Color FiftyColor { get => CSV_Fifty.StepColor; private set => CSV_Fifty.StepColor = value; }
        public Color SixtyColor { get => CSV_Sixty.StepColor; private set => CSV_Sixty.StepColor = value; }
        public Color SeventyColor { get => CSV_Seventy.StepColor; private set => CSV_Seventy.StepColor = value; }
        public Color EightyColor { get => CSV_Eighty.StepColor; private set => CSV_Eighty.StepColor = value; }
        public Color NinetyColor { get => CSV_Ninety.StepColor; private set => CSV_Ninety.StepColor = value; }
        public Color NinetyFiveColor { get => CSV_NinetyFive.StepColor; private set => CSV_NinetyFive.StepColor = value; }
        public Color NinetyEightColor { get => CSV_NinetyEight.StepColor; private set => CSV_NinetyEight.StepColor = value; }
        public Color NinetyNineColor { get => CSV_NinetyNine.StepColor; private set => CSV_NinetyNine.StepColor = value; }
        public Color HundredColor { get => CSV_Hundred.StepColor; private set => CSV_Hundred.StepColor = value; }

        public void Visualise(IColorPalette palette)
        {
            ZeroColor = palette.Zero;
            TenColor = palette.Ten;
            TwentyColor = palette.Twenty;
            ThirtyColor = palette.Thirty;
            FortyColor = palette.Forty;
            FiftyColor = palette.Fifty;
            SixtyColor = palette.Sixty;
            SeventyColor = palette.Seventy;
            EightyColor = palette.Eighty;
            NinetyColor = palette.Ninety;
            NinetyFiveColor = palette.NinetyFive;
            NinetyEightColor = palette.NinetyEight;
            NinetyNineColor = palette.NinetyNine;
            HundredColor = palette.Hundred;
        }
    }
}
