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
            var assemblies = GetOrderedRelevantAssemblies();
            foreach (var assembly in assemblies)
            {
                var assemblyThemeProviders = FindDefaultThemeProvidersInAssembly(assembly);
                if (assemblyThemeProviders.Any())
                    return assemblyThemeProviders.First();
            }
            return null;
        }

        private static IEnumerable<Assembly> GetOrderedRelevantAssemblies()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var relevantAssemblies = assemblies.Where(IsRelevantAssembly);

            var entry = Assembly.GetEntryAssembly();
            Assembly? main = null;
            if (entry != null && IsRelevantAssembly(entry))
                main = entry;

            var ordered = relevantAssemblies
                .OrderBy(a => a.GetName().Name)
                .ToList();

            if (main == null)
                return ordered;

            IEnumerable<Assembly> orderedWithoutMain;
            var mainName = main.GetName().Name;
            if (!string.IsNullOrEmpty(mainName))
                orderedWithoutMain = ordered
                    .Where(a => !mainName.Equals(a.GetName().Name));
            else
                orderedWithoutMain = ordered;

            return orderedWithoutMain.Prepend(main);
        }
        static bool IsRelevantAssembly(Assembly assembly)
        {
            var name = assembly.GetName().Name;
            if (string.IsNullOrEmpty(name))
                return false;

            bool isSystem = name.StartsWith("System.", StringComparison.OrdinalIgnoreCase);
            bool isMicrosoft = name.StartsWith("Microsoft.", StringComparison.OrdinalIgnoreCase);
            return !isSystem && !isMicrosoft;
        }

        private static IEnumerable<IThemeProvider> FindDefaultThemeProvidersInAssembly(Assembly assembly)
        {
            var types = assembly.GetTypes().OrderBy(t => t.Name);
            foreach (var type in types)
            {
                if (!IsDefaultThemeProvider(type))
                    continue;

                var instance = (IThemeProvider?)Activator.CreateInstance(type);
                if (instance != null)
                    yield return instance;
            }
        }
        private static bool IsDefaultThemeProvider(Type type)
            => typeof(IDefaultThemeProvider).IsAssignableFrom(type) &&
                !type.IsInterface && !type.IsAbstract;
    }
}
