using System;
using System.Collections.Generic;
using System.Text;

namespace ClimaAPI.Models
{
    public class City
    {
        public int id { get; set; }

        public int timezone { get; set; }

        public string name { get; set; }

        public double lon { get; set; }

        public double lat { get; set; }

        public ICollection<Weather> weather { get; set; }
    }

}
