using AdoNetWinformsApp.Entities;
using AdoNetWinformsApp.Entities.Constants;
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
            var countries = await _context.Countries.ToListAsync();
            return countries;
        }

        public async Task<List<Country>> GetCities()
        {
            var countries = await _context.Countries.ToListAsync();
            return countries;
        }

    }
}
