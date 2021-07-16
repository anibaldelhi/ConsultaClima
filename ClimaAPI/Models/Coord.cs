using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClimaAPI.Models
{
    public class Coord
    {
        [Key]
       public int id { get; set; }

        public double lon { get; set; }

        public double lat { get; set; }
    }
}
