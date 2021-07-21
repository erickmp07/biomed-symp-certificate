using System.Collections.Generic;
using System.Linq;
using BiomedSympCertificate.Application.ViewModels;
using BiomedSympCertificate.Domain.Model.Entities;
using BiomedSympCertificate.Domain.Model.Interfaces;

namespace BiomedSympCertificate.Application.AppServices.Implementations
{
    public class BiomedAppService : IBiomedAppService
    {
        private readonly ISpreadsheetReaderService _spreadsheetReaderService;
        private readonly ISpreadsheetWriterService _spreadsheetWriterService;
        private readonly ISubscriberService _subscriberService;

        public BiomedAppService(
            ISpreadsheetReaderService spreadsheetReaderService,
            ISpreadsheetWriterService spreadsheetWriterService,
            ISubscriberService subscriberService)
        {
            _spreadsheetReaderService = spreadsheetReaderService;
            _spreadsheetWriterService = spreadsheetWriterService;
            _subscriberService = subscriberService;
        }

        public void CreateDistinctSubscriberReport(
            BiomedViewModel biomedViewModel)
        {
            var subscribers = new List<Subscriber>();

            foreach (var filePath in biomedViewModel.FilesPaths)
            {
                var spreadsheetRead = _spreadsheetReaderService.Read(filePath);

                subscribers.AddRange(_subscriberService.CreateSubscribers(spreadsheetRead));
            }

            var distinctSubscribers = _subscriberService.GetDistinctSubscribers(subscribers, biomedViewModel.MinimumCount)
                .ToList();

            distinctSubscribers.Sort();
            
            _spreadsheetWriterService.Write(biomedViewModel.ResultPath, distinctSubscribers);
        }
    }
}
