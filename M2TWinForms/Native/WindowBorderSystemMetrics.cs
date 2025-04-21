using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Native
{
    internal class WindowBorderSystemMetrics
    {
        public int Border { get; }
        public int FixedFrame { get; }
        public int SizeFrame { get; }
        public int Total { get => FixedFrame + Border + SizeFrame; }

        private WindowBorderSystemMetrics(int border, int fixedFrame, int sizeFrame)
        {
            Border = border;
            FixedFrame = fixedFrame;
            SizeFrame = sizeFrame;
        }

        public static WindowBorderSystemMetrics GetForX()
        {
            int border = NativeMethods.GetSystemMetrics(NativeConstants.SM_CXBORDER);
            int fixedFrame = NativeMethods.GetSystemMetrics(NativeConstants.SM_CXFIXEDFRAME);
            int sizeFrame = NativeMethods.GetSystemMetrics(NativeConstants.SM_CXSIZEFRAME);
            return new WindowBorderSystemMetrics(border, fixedFrame, sizeFrame);
        }
        public static WindowBorderSystemMetrics GetForY()
        {
            int border = NativeMethods.GetSystemMetrics(NativeConstants.SM_CYBORDER);
            int fixedFrame = NativeMethods.GetSystemMetrics(NativeConstants.SM_CYFIXEDFRAME);
            int sizeFrame = NativeMethods.GetSystemMetrics(NativeConstants.SM_CYSIZEFRAME);
            return new WindowBorderSystemMetrics(border, fixedFrame, sizeFrame);
        }
    }
}
