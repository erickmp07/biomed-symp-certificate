using DryIoc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BiomedSympCertificate.Infrastructure.IoC
{
    public static class ContentRootBootstrapper
    {
        internal static Container Container;

        public static Container RegisterServicesInNewContainer()
        {
            Container = new Container(rules => rules.WithoutThrowOnRegisteringDisposableTransient());

            RegisterAllBootstrappers();

            Container.Validate();

            return Container;
        }

        private static void RegisterAllBootstrappers()
        {
            try
            {
                //Essa exceção pode ser ignorada!
                var bootstrappers =
                    AppDomain.CurrentDomain.GetAssemblies()
                        .SelectMany(GetLoadableTypes)
                        .Where(x =>
                            !x.IsInterface &&
                            !x.IsAbstract &&
                            typeof(IBootstrapperRegister).IsAssignableFrom(x))
                        .ToList();

                foreach (var bootstrapperRegister in bootstrappers.Select(Activator.CreateInstance).Cast<IBootstrapperRegister>())
                {
                    bootstrapperRegister.Register(Container);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //https://stackoverflow.com/a/29379834/2601015
        [System.Diagnostics.DebuggerHidden]
        public static IEnumerable<Type> GetLoadableTypes(this Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly), "Assembly not found!");
            try
            {
                return assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException e)
            {
                return e.Types.Where(t => t != null);
            }
        }
    }
}
