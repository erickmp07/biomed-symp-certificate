using DryIoc;

namespace BiomedSympCertificate.Infrastructure.IoC
{
    public static class IocResolver
    {
        public static TImplementation Resolve<TImplementation>()
        {
            return ContentRootBootstrapper.Container.Resolve<TImplementation>();
        }
    }
}
