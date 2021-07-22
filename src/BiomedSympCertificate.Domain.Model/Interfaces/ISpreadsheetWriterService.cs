using System.Collections.Generic;
using BiomedSympCertificate.Domain.Model.Entities;

namespace BiomedSympCertificate.Domain.Model.Interfaces
{
    public interface ISpreadsheetWriterService
    {
        void Write(
            string filePath,
            List<Subscriber> subscribers);
    }
}
