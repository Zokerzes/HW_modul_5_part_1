﻿using AdoNetWinformsApp.Entities;
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
            return await _context.Countries.ToListAsync();

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

        public async Task<Country?> GetCountryById(int id)
        {
            return await _context.Countries.FindAsync(id);
        }

        public async Task EditCountry(Country country, string newCountryName, decimal newCountryArea, int newCountryPartOfWorld)
        {
            country.Name = newCountryName;
            country.Area = newCountryArea;
            country.PartOfWorld = (PartOfWorld)newCountryPartOfWorld;
            await _context.SaveChangesAsync();
        }

        public async Task DeletedGood(int id)
        {
            var country = await _context.Countries.FindAsync(id);
            if (country != null)
            {
                _context.Countries.Remove(country);
                await _context.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Такой страны не существует");
            }
        }


        public async Task<List<KeyValuePair<string, int>>> GetCitiesPairs()
        {
            return await _context.Cities
               .Select(x => new KeyValuePair<string, int>(x.Name, x.Id))
               .ToListAsync();
        }
    }
}
