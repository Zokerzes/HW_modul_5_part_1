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

        public CountryService(CountryContext context)
        {
            _context = context;
        }



    }
}
