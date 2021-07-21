using System.Data;
using System.IO;
using BiomedSympCertificate.Domain.Model.Interfaces;
using ExcelDataReader;

namespace BiomedSympCertificate.Domain.Service.Services
{
    public class SpreadsheetReaderService : ISpreadsheetReaderService
    {
        public DataSet Read(
            string filePath)
        {
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    return reader.AsDataSet(new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = tableReader => new ExcelDataTableConfiguration { UseHeaderRow = true }
                    });
                }
            }
        }
    }
}
