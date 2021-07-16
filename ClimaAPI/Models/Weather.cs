using System;
using System.Collections.Generic;
using System.Text;

namespace ClimaAPI.Models
{
    public class Weather
    {
        public int id { get; set; }

        public string main { get; set; }

        public string description { get; set; }

        public int cityid { get; set; }
    }
}
