﻿using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public interface IParkDAL
    {
        List<Park> GetAllParks();
        Park GetPark(string id);
        void SaveSurvey(Park p);
        List<Park> GetWeather(string id);
    }
}
