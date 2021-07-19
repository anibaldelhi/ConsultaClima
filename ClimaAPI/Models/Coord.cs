using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClimaAPI.Models
{
    public class Coord
    {
        [Key, ForeignKey("City"), JsonIgnore]
       public int idCiudad { get; set; }

        public double lon { get; set; }

        public double lat { get; set; }

        [JsonIgnore]
        public virtual City city { get; set; }
    }
}
