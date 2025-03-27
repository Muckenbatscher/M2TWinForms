using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.MaterialDesign
{
    public class HctColor
    {
        private double _hue;
        public double Hue 
        {
            get => _hue;
            set => _hue = (value % 360 + 360) % 360;
        }
        private double _chroma;
        public double Chroma 
        { 
            get => _chroma;
            set => _chroma = Math.Max(Math.Min(value, 120), 0);
        }
        private double _tone;
        public double Tone 
        {
            get => _tone;
            set => _tone = Math.Max(Math.Min(value, 100), 0);
        }

        public HctColor(double hue, double chroma, double tone)
        {
            Hue = hue;
            Chroma = chroma;
            Tone = tone;
        }
    }
}
