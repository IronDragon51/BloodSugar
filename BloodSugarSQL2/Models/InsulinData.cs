using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BloodSugar.Models
{
    public partial class InsulinData
    {

        public string userPhone { get; set; }

        public DateTime measureDate { get; set; }

        public string timeOfDay { get; set; }

        public double mgInsulin { get; set; }



        public InsulinData(string p, DateTime d, string t, double s)
        {
            userPhone = p;
            measureDate = d;
            timeOfDay = t;
            mgInsulin = s;
        }
    }
}
