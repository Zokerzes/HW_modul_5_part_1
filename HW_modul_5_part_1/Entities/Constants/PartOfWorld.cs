using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetWinformsApp.Entities.Constants
{
    public enum PartOfWorld
    {
        [Description("Европа")]
        Europe = 1,
        [Description("Азия")]
        Asia,

        Africa,

        America,


        Australia
    }
}
