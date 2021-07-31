using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace TampaBayCoffee.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Name { get; set; }

        public string Origin { get; set; }

        public string Process { get; set; }

        public string ElevationRangeInMeters { get; set; }

        public string Notes { get; set; }
    }
}