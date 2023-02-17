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
        private WarehouseContext _context;

        public CountryService(WarehouseContext context)
        {
            _context = context;
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<List<string>> GetCountryNamesAsinc()
        {
            return await _context.Countries
                .Select(c => c.Name)
                .ToListAsync();
        }

        public async Task<List<string>> GetCountryCapitalsAsinc()
        {
            return await _context.Countries
                .Select(c => c.Capital)
                .ToListAsync();
        }

        public async Task<List<string>> GetEuropiaCountryNamesAsinc()
        {
            return await _context.Countries
                .Where(x=>x.PartOfWord == PartOfWord.Europe)
                .Select(c => c.Name)
                .ToListAsync();
        }

        public async Task<List<string>> GetCountryNamesWithAreaMoreThenAsinc(decimal area )
        {
            return await _context.Countries
                .Where(x => x.Area > area)
                .Select(c => c.Name)
                .ToListAsync();
        }

        public async Task<List<Country>> GetCountriesWithLetterAsinc(params char[] letters)
        {
            return await _context.Countries
                .Where(x => letters.All(l=>x.Name.Contains(l)))
                .ToListAsync();
        }

        public async Task<List<Country>> GetCountriesWithLetterBeginAsinc(char letter)
        {
            return await _context.Countries
                .Where(x => x.Name.StartsWith(letter))
                .ToListAsync();
        }

        public async Task<List<string>> GetCountryNamesWithAreaBetweenAsinc(decimal minArea, decimal maxArea)
        {
            return await _context.Countries
                .Where(x => x.Area>=minArea && x.Area<maxArea)
                .Select(c => c.Name)
                .ToListAsync();
        }

        public async Task<List<string>> GetCountryNamesWithPopulationAsinc(int population)
        {
            return await _context.Countries
                .Where(x => x.Population > population)
                .Select(c => c.Name)
                .ToListAsync();
        }

        public async Task<List<Country>> GetTopAreaCountries(int top)
        {
            return await _context.Countries
                .OrderByDescending(x=>x.Area)
                .Take(top)   //take взять skip пропустить
                .ToListAsync();
        }

        public async Task<List<Country>> GetTopPopulationCountries(int top)
        {
            return await _context.Countries
                .OrderByDescending(x => x.Population)
                .Take(top)  
                .ToListAsync();
        }

        public async Task<Country?> GetTopAreaCountry()
        {
            return await _context.Countries
                .OrderByDescending(x => x.Area)
                .FirstOrDefaultAsync();   //take взять skip пропустить
        }

        public async Task<Country?> GetTopPopulationCountry()
        {
            return await _context.Countries
                .OrderByDescending(x => x.Population)
                .FirstOrDefaultAsync();   //take взять skip пропустить
        }

        public async Task<Country?> GetCountryOfAfricaWithMinArea()
        {
            return await _context.Countries
                .Where(x=>x.PartOfWord == PartOfWord.Africa)
                .OrderBy(x=>x.Area)
                .FirstOrDefaultAsync();   //take взять skip пропустить
        }

        public async Task<decimal> GetAfricaAverageArea()
        {
            return await _context.Countries
                .Where(x => x.PartOfWord == PartOfWord.Africa)
                .AverageAsync(x => x.Area);
        }

       

    }
}
