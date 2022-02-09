using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Core.Dtos.Weather
{
    public class SunDto
    {
        public string Rise { get; set; }
        public Int64 EpochRise { get; set; }
        public string Set { get; set; }
        public Int64 EpochSet { get; set; }
    }
}
