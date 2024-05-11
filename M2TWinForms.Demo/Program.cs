using M2TWinForms.Interfaces.DefaultTheme;
using M2TWinForms.Services;
using M2TWinForms.Services.DefaultTheme;

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
            ApplicationConfiguration.Initialize();
            IDefaultThemeService darkThemeService = new DefaultDarkThemeService();
            CurrentLoadedThemeManager.LoadTheme(darkThemeService.GetTheme());
            Application.Run(new Form1());
        }
    }
}