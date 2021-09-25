using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Task.Two.ConsoleCore.Models;

namespace Task.Two.ConsoleCore.Services
{
    public class ExcelOperations
    {
        public async ValueTask CreateAndSaveExcelFile(IEnumerable<CountriesModel> countries, FileInfo fileInfo)
        {
            if (fileInfo.Exists)
                fileInfo.Delete();

            using var excelPackage = new ExcelPackage(fileInfo);
            var workBook = excelPackage.Workbook.Worksheets.Add("Countries");
            var excelBuilder = workBook.Cells["A1"].LoadFromCollection(countries, true);
            excelBuilder.AutoFitColumns();
            await excelPackage.SaveAsync();
        }
    }
}
