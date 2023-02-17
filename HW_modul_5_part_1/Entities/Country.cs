using AdoNetWinformsApp.Entities.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinformsApp.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Area { get; set; }
        public PartOfWord PartOfWord { get; set; }
    }
}
