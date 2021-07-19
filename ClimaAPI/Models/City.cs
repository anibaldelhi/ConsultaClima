using System;
using System.Collections.Generic;
using System.Text;

namespace ClimaAPI.Models
{
    public class City
    {
        public virtual Coord coord { get; set; }

        public ICollection<Weather> weather { get; set; }

        public int timezone { get; set; }

        public int id { get; set; }

        public string name { get; set; }

    }

}
