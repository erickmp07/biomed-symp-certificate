using BiomedSympCertificate.Domain.Model.Entities;
using BiomedSympCertificate.Domain.Model.Interfaces;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BiomedSympCertificate.Domain.Service.Services
{
    public class SpreadsheetWriterService : ISpreadsheetWriterService
    {
        public void Write(
            string filePath, 
            List<Subscriber> subscribers)
        {
            var fileInfo = new FileInfo($"{filePath}\\Assinantes-Distintos.xlsx");
            
            using (var excelPackage = new ExcelPackage(fileInfo))
            {
                var excelSheet = AdicionarPlanilha(excelPackage.Workbook.Worksheets, "Inscritos");

                excelSheet.Cells[1, 1].Value = "Nome";
                excelSheet.Cells[1, 2].Value = "Email";
                excelSheet.Cells[1, 3].Value = "Matrícula";

                for (var i = 0; i < subscribers.Count; i++)
                {
                    excelSheet.Cells[i + 2, 1].Value = subscribers[i].Name;
                    excelSheet.Cells[i + 2, 2].Value = subscribers[i].Email;
                    excelSheet.Cells[i + 2, 3].Value = subscribers[i].Registration;
                }
                
                excelPackage.Save();
            }
        }

        private ExcelWorksheet AdicionarPlanilha(
            ExcelWorksheets spreadsheets,
            string spreadsheetName)
        {
            var hasSpreadsheetWithSameName = spreadsheets
                .Any(spreadsheet => string.CompareOrdinal(spreadsheetName, spreadsheet.Name) == 0);

            if (hasSpreadsheetWithSameName)
            {
                spreadsheets.Delete(spreadsheetName);
            }

            return spreadsheets.Add(spreadsheetName);
        }
    }
}
