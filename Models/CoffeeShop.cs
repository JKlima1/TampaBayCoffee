using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TampaBayCoffee.Models
{
    public class CoffeeShop
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        public string Zip_Code { get; set; }
        public string StreetName { get; set; }
        public Decimal Add_Number { get; set; }

        public Single Longitude { get; set; }

        public Single Latitude { get; set; }

        public String NatGrid_Coord { get; set; }

        public bool IsRoaster { get; set; }

        public string CoffeeBrandsUsed { get; set; }
    }
}
