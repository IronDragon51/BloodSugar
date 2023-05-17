using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BloodSugar.Models
{
    public partial class CarbData
    {

        public string userPhone { get; set; }

        public DateTime measureDate { get; set; }

        public string timeOfDay { get; set; }

        public double gCarb { get; set; }



        public CarbData(string p, DateTime d, string t, double s)
        {
            userPhone = p;
            measureDate = d;
            timeOfDay = t;
            gCarb = s;
        }
    }
}
