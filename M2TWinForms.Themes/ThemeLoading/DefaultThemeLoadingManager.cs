using M2TWinForms.Themes.ThemeProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace M2TWinForms.Themes.ThemeLoading
{
    public class DefaultThemeLoadingManager
    {
        public static IThemeProvider? FindDefaultThemeProvider()
        {
            var themeProviders = new List<IThemeProvider>();
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var assembly in assemblies)
            {
                var assemblyThemeProviders = FindDefaultThemeProvidersInAssembly(assembly);
                themeProviders.AddRange(assemblyThemeProviders);
            }

            return themeProviders.FirstOrDefault();
        }

        private static IEnumerable<IThemeProvider> FindDefaultThemeProvidersInAssembly(Assembly assembly)
        {
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (typeof(IDefaultThemeProvider).IsAssignableFrom(type) && !type.IsInterface)
                {
                    var instance = (IThemeProvider?)Activator.CreateInstance(type);
                    if (instance != null)
                    {
                        yield return instance;
                    }
                }
            }
        }
    }
}
