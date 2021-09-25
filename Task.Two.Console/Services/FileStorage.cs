using OfficeOpenXml;
using System;
using System.IO;
using System.Reflection;

namespace Task.Two.ConsoleCore.Services
{
    public class FileStorage
    {
        public FileInfo Store()
        {
            var ExcelFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xlsx";
            var ExcelPath = Path.Combine(AppContext.BaseDirectory, ExcelFile);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var file = new FileInfo(ExcelPath);
            return file;
        }
    }
}
