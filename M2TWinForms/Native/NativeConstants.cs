using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Native
{
    internal class NativeConstants
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int WM_NCPAINT = 0x85;
        public const int WM_NCCALCSIZE = 0x0083;
        public const int WM_SYSCOMMAND = 0x0112;

        public const int HT_CAPTION = 0x2;
        public const int HT_LEFT = 0xA;
        public const int HT_RIGHT = 0xB;
        public const int HT_TOP = 0xC;
        public const int HT_TOPLEFT = 0xD;
        public const int HT_TOPRIGHT = 0xE;
        public const int HT_BOTTOM = 0xF;
        public const int HT_BOTTOMLEFT = 0x10;
        public const int HT_BOTTOMRIGHT = 0x11;

        public const int CS_DROPSHADOW = 0x20000;
        public const int CS_DBLCLKS = 0x8;

        public const int WS_MINIMIZEBOX = 0x20000;
        public const int WS_THICKFRAME = 0x40000;
        public const int WS_CAPTION = 0xC00000;

        public const int SM_CXBORDER = 0x5;
        public const int SM_CYBORDER = 0x6;
        public const int SM_CXFIXEDFRAME = 0x7;
        public const int SM_CYFIXEDFRAME = 0x8;
        public const int SM_CXSIZEFRAME = 0x20;
        public const int SM_CYSIZEFRAME = 0x21;
        public const int SM_CXCAPTION = 0x32;
        public const int SM_CYCAPTION = 0x33;

        public const int SC_MAXIMIZE = 0xF030;
        public const int SC_RESTORE = 0xF120;
    }
}
