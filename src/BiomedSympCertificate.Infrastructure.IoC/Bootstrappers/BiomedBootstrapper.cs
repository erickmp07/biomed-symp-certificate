using BiomedSympCertificate.Application.AppServices;
using BiomedSympCertificate.Application.AppServices.Implementations;
using BiomedSympCertificate.Domain.Model.Interfaces;
using BiomedSympCertificate.Domain.Service.Services;
using DryIoc;

namespace BiomedSympCertificate.Infrastructure.IoC.Bootstrappers
{
    public class BiomedBootstrapper : IBootstrapperRegister
    {
        public void Register(
            Container container)
        {
            //AppServices
            container.Register<IBiomedAppService, BiomedAppService>();

            // Services
            container.Register<ISpreadsheetReaderService, SpreadsheetReaderService>();
            container.Register<ISpreadsheetWriterService, SpreadsheetWriterService>();
            container.Register<ISubscriberService, SubscriberService>();
        }
    }
}
