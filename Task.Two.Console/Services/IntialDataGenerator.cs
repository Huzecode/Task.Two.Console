using System.Collections.Generic;
using Task.Two.ConsoleCore.Models;

namespace Task.Two.ConsoleCore.Services
{
    public class IntialDataGenerator
    {
        public IEnumerable<CountriesModel> Generate()
        {
            var countriesList = new List<CountriesModel>()
            {
                new CountriesModel(){ CountryId = 1001, CountryName = "Indonesia", CountrySlug = "indonesia", CountryIso2 = "ID" },
                new CountriesModel(){ CountryId = 1002, CountryName = "Sierra Leone", CountrySlug = "sierra-leone", CountryIso2 = "SL" },
                new CountriesModel(){ CountryId = 1003, CountryName = "Ukraine", CountrySlug = "ukraine", CountryIso2 = "UA" },
                new CountriesModel(){ CountryId = 1004, CountryName = "Namibia", CountrySlug = "namibia", CountryIso2 = "NA" },
                new CountriesModel(){ CountryId = 1005, CountryName = "Maldives", CountrySlug = "maldives", CountryIso2 = "MV" }
            };
            return countriesList;
        }
    }
}
