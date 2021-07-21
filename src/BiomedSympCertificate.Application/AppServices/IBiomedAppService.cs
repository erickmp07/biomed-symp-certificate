using BiomedSympCertificate.Application.ViewModels;

namespace BiomedSympCertificate.Application.AppServices
{
    public interface IBiomedAppService
    {
        void CreateDistinctSubscriberReport(
            BiomedViewModel biomedViewModel);
    }
}
