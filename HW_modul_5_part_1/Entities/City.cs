using AdoNetWinformsApp.Entities;
using AdoNetWinformsApp.Entities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_modul_5_part_1.Entities
{
    public class City
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Population { get; set; }
        public bool IsCapital { get; set; } = false;
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        
    }
}
