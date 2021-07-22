using DryIoc;

namespace BiomedSympCertificate.Infrastructure.IoC
{
    public interface IBootstrapperRegister
    {
        void Register(
            Container container);
    }
}
