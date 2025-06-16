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
        // Importiert die Win32-API-Funktion "LoadString".
        // Diese Funktion lädt eine String-Ressource aus der ausführbaren Datei,
        // die mit einem bestimmten Modul verbunden ist.
        [DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int LoadString(IntPtr hInstance, uint uID, StringBuilder lpBuffer, int nBufferMax);

        // Importiert die Win32-API-Funktion "GetModuleHandle".
        // Ruft ein Modulhandle für die angegebene Moduldatei ab.
        // Ein Null-Parameter ruft das Handle der aufrufenden Prozessdatei ab.
        // Wir übergeben "user32.dll", um das Handle dieser Systembibliothek zu bekommen.
        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        // Eine öffentliche Methode, um den lokalisierten Text für einen Standard-Button-Typ abzurufen.
        public static string GetLocalizedString(StockButtonId buttonId)
        {
            // Puffer für den String vorbereiten.
            const int maxChars = 256;
            var buffer = new StringBuilder(maxChars);

            // Handle zur user32.dll holen, wo sich die Standard-UI-Strings befinden.
            IntPtr user32Handle = GetModuleHandle("user32.dll");
            if (user32Handle == IntPtr.Zero)
            {
                // Wenn das Handle nicht geladen werden kann, geben wir einen Fallback-Text zurück.
                return GetFallbackText(buttonId);
            }

            // Die LoadString-Funktion aufrufen, um den lokalisierten Text zu laden.
            // Die ID des Strings wird aus unserem Enum übergeben.
            int result = LoadString(user32Handle, (uint)buttonId, buffer, buffer.Capacity);
            bool resultFound = result > 0;
            if (!resultFound)
                return GetFallbackText(buttonId);

            // Remove Ampersand character, functions as mnemonic indicator for key shortcuts
            var cleanedResult = buffer.ToString().Replace("&", "");
            return cleanedResult;
        }

        // Fallback-Methode, falls das Laden der Ressource fehlschlägt.
        // So stellen wir sicher, dass der Button immer eine Beschriftung hat.
        private static string GetFallbackText(StockButtonId buttonId)
        {
            switch (buttonId)
            {
                case StockButtonId.Ok: return "OK";
                case StockButtonId.Cancel: return "Cancel";
                case StockButtonId.Abort: return "Abort";
                case StockButtonId.Retry: return "Retry";
                case StockButtonId.Ignore: return "Ignore";
                case StockButtonId.Yes: return "Yes";
                case StockButtonId.No: return "No";
                case StockButtonId.Close: return "Close";
                case StockButtonId.Help: return "Help";
                case StockButtonId.TryAgain: return "Try Again";
                case StockButtonId.Continue: return "Continue";
                default: return string.Empty;
            }
        }
    }

    // Dieses Enum enthält die Standard-IDs für die Button-Texte,
    // wie sie in den Windows-Ressourcen definiert sind.
    // Die Werte entsprechen den IDs in der user32.dll.
    public enum StockButtonId : uint
    {
        Ok = 800,
        Cancel = 801,
        Abort = 802,
        Retry = 803,
        Ignore = 804,
        Yes = 805,
        No = 806,
        Close = 807,
        Help = 808,
        TryAgain = 809,
        Continue = 810
    }
}
