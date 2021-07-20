using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace ClimaAPI.Models
{
    public class Weather
    {
        public int id { get; set; }

        public string main { get; set; }

        public string description { get; set; }

        [JsonIgnore]
        public virtual ICollection<City> city { get; set; }
    }
}
