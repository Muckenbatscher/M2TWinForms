using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Native
{
    internal static class NativeLocalizer
    {
        public static string GetLocalizedString(NativeButtons buttonId)
        {
            IntPtr user32Handle = NativeMethods.GetModuleHandle("user32.dll");
            if (user32Handle == IntPtr.Zero)
                return GetFallbackText(buttonId);

            const int maxChars = 256;
            var buffer = new StringBuilder(maxChars);
            int result = NativeMethods.LoadString(user32Handle, (uint)buttonId, buffer, buffer.Capacity);
            bool resultFound = result > 0;
            if (!resultFound)
                return GetFallbackText(buttonId);

            // Remove Ampersand character, functions as mnemonic indicator for key shortcuts
            var cleanedResult = buffer.ToString().Replace("&", "");
            return cleanedResult;
        }

        private static string GetFallbackText(NativeButtons buttonId)
            => buttonId.ToString();
    }

}
