using System;
using System.Collections.Generic;
using System.Text;

namespace JsonHW
{
    public class Weather
    {
        public int Temperature { get; set; }
        public int TemperatureCity { get; set; }
        public int TemperatureRegion { get; set; }
        public int TemperatureCountry { get; set; }
        public string WeatherCity { get; set; }
        public string WeatherRegion { get; set; }
        public string WeatherCountry { get; set; }
    }
}
