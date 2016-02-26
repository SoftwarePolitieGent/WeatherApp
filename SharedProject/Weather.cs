using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject
{
    public class Weather
    {
        public string Humidity { get; set; }
        public string Sunrise { get; internal set; }
        public string Sunset { get; internal set; }
        public string Temperature { get; set; }
        public string Title { get; set; }
        public string Visibility { get; internal set; }
        public string Wind { get; set; }

    }
}
