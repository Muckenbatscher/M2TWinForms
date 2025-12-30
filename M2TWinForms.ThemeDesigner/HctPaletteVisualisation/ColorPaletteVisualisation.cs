using MaterialTheming.MaterialDesign;

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

        public void Visualise(HctTonalPalette palette)
        {
            ZeroColor = GetColorFromPaletteForTone(palette, 0);
            TenColor = GetColorFromPaletteForTone(palette, 10);
            TwentyColor = GetColorFromPaletteForTone(palette, 20);
            ThirtyColor = GetColorFromPaletteForTone(palette, 30);
            FortyColor = GetColorFromPaletteForTone(palette, 40);
            FiftyColor = GetColorFromPaletteForTone(palette, 50);
            SixtyColor = GetColorFromPaletteForTone(palette, 60);
            SeventyColor = GetColorFromPaletteForTone(palette, 70);
            EightyColor = GetColorFromPaletteForTone(palette, 80);
            NinetyColor = GetColorFromPaletteForTone(palette, 90);
            NinetyFiveColor = GetColorFromPaletteForTone(palette, 95);
            NinetyEightColor = GetColorFromPaletteForTone(palette, 98);
            NinetyNineColor = GetColorFromPaletteForTone(palette, 99);
            HundredColor = GetColorFromPaletteForTone(palette, 100);
        }

        private static Color GetColorFromPaletteForTone(HctTonalPalette palette, double tone)
        {
            var rgbColor = palette.GetHctForTone(0).ToRgbColor();
            return Color.FromArgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);
        }
    }
}
