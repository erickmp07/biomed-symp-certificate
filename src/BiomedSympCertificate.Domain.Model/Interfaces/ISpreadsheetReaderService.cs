using System.Data;

namespace BiomedSympCertificate.Domain.Model.Interfaces
{
    public interface ISpreadsheetReaderService
    {
        DataSet Read(
            string filePath);
    }
}
