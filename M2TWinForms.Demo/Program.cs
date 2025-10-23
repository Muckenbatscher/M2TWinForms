using M2TWinForms.Themes;
using M2TWinForms.Themes.MaterialDesign;

namespace M2TWinForms.Demo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
#if NET8_0_OR_GREATER
            ApplicationConfiguration.Initialize();
#endif

            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}