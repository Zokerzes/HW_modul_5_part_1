using AdoNetWinformsApp.Entities;
using AdoNetWinformsApp.Entities.Constants;
using HW_modul_5_part_1.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinformsApp
{

    public class CountryService
    {
        private CountryContext _context;

        public CountryService()
        {
            _context = new CountryContext();
        }

        public CountryService(CountryContext context)
        {
            _context = new CountryContext();
        }

        public async Task<List<Country>> GetCountries()
        {
            return  await _context.Countries.ToListAsync();
            
        }

        public async Task<List<City>> GetCities()
        {
              
            return await _context.Cities.ToListAsync();
        }

        public async Task<List<KeyValuePair<string, int>>> GetCountriesPairs()
        {
            return await _context.Countries
               .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
               .ToListAsync();
        }


        
        public async Task AddCountry(string name, decimal area, PartOfWorld countryPartOfWorldId)
        {
            var country = new Country { Name = name, Area = area, PartOfWorld = countryPartOfWorldId };
            await _context.Countries.AddAsync(country);
            await _context.SaveChangesAsync();
        }
    }
}
