using System;
using Task.Two.ConsoleCore.Services;

namespace Task.Two.ConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task two!");

            // reading excel content list 
            var listOfCountries = ServiceManager.Instance.IntialDataGenerator.Generate();

            // reading file name and path for storing it
            var file = ServiceManager.Instance.FileStorage.Store();

            // creating and saving the excel file by giving content and file name and path
            // the file path of saving is project folder/bin/debug/net5.0/ the file by name Task.Two.ConsoleCore
            ServiceManager.Instance.ExcelOperations.CreateAndSaveExcelFile(listOfCountries, file).GetAwaiter().GetResult();
        }
    }
}
