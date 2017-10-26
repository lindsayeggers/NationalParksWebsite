﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    public class Weather
    {
        public string ParkCodeWeather { get; set; }
        public int FiveDayForecastValue { get; set; }
        public int Low { get; set; }
        public int High { get; set; }
        public string Forecast { get; set; }

        public double CalculateCelsius(int temp)
        {
            double cTemp;
            cTemp =(temp - 32) * (5.0 / 9);
            return (int)cTemp;
        }
    }
}