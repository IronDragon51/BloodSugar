using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BloodSugar.Models
{
    public partial class BloodSugarData
    {
        public static DateTime date1 = new DateTime(2010, 1, 1, 8, 0, 0);
        public static DateTime date2 = new DateTime(2004, 1, 3, 11, 0, 0);

        public static List<BloodSugarData> bsDatas = new List<BloodSugarData>
        {

            new BloodSugarData("11231231231", date1, "morning", 12),
            new BloodSugarData("36703245432", date1, "night", 10),
            new BloodSugarData("36703124871", date1, "afternoon", 3),
            new BloodSugarData("36703245432", date1, "evening", 7),
            new BloodSugarData("36202347834", date2, "afternoon", 1),
            new BloodSugarData("36703124871", date2, "evening", 5),
            new BloodSugarData("36702347834", date2, "morning", 8),


        };


        public string userPhone { get; set; }

        public DateTime measureDate { get; set; }

        public string timeOfDay { get; set; }

        public double mgBloodSugar { get; set; }



        public BloodSugarData(string p, DateTime d, string t, double s)
        {
            userPhone = p;
            measureDate = d;
            timeOfDay = t;
            mgBloodSugar = s;
        }
    }
}
