using BiomedSympCertificate.Infrastructure.IoC;
using DryIoc;

namespace BiomedSympCertificate.Presentation.Bootstrappers
{
    public class PresentationBootstrapper : IBootstrapperRegister
    {
        public void Register(
            Container container)
        {
            // View
            container.Register<IPrincipalForm, PrincipalForm>();

            // Presenter
            container.Register<IPrincipalPresenter, PrincipalPresenter>();
        }
    }
}
