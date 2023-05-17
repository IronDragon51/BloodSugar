using BloodSugar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BloodSugar.Controllers
{
    public class MeasurePageController : Controller
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
        public static List<InsulinData> iDatas = new List<InsulinData>
        {

            new InsulinData("23123124124", date1, "morning", 12),
            new InsulinData("36202347834", date2, "afternoon", 1),
            new InsulinData("36703124871", date1, "morning", 5),
            new InsulinData("36703245432", date1, "night", 10),
            new InsulinData("36702347834", date2, "morning", 8),

        };

        public static List<CarbData> cDatas = new List<CarbData>
        {

            new CarbData("643563564356", date1, "morning", 12),
            new CarbData("643563564356", date2, "afternoon", 1),
            new CarbData("36703124871", date1, "evening", 5),
            new CarbData("367033452341", date1, "night", 10),
            new CarbData("367033452341", date2, "morning", 8),
            new CarbData("367033452341", date1, "afternoon", 3),
            new CarbData("367033452341", date2, "evening", 7),
            new CarbData("367033452341", date1, "evening", 5),
            new CarbData("643563564356", date1, "night", 10),
            new CarbData("342523452345", date2, "morning", 8),


        };





        public IActionResult AddBSMeasure()
        {
            return View();
        }

        public IActionResult AddInsulinMeasure()
        {
            return View();
        }

        public IActionResult AddCarbMeasure()
        {
            return View();
        }


        public IActionResult BSMeasurePageList()
        {
            return View(bsDatas);
        }

        public IActionResult InsulinMeasurePageList()
        {
            return View(iDatas);
        }

        public IActionResult CarbMeasurePageList()
        {
            return View(cDatas);
        }





        [HttpPost]
        public IActionResult AddNewBSMeasure()
        {

            string userPhone = HttpContext.Request.Form["userPhone"];
            DateTime measureDate = DateTime.Now;
            string timeOfDay = HttpContext.Request.Form["timeOfDay"];

            double mgBloodSugar = double.Parse(HttpContext.Request.Form["bloodSugar"]);



            bsDatas.Add(new BloodSugarData(userPhone, measureDate, timeOfDay, mgBloodSugar));

            return View("BSMeasurePageList", bsDatas);


        }

        [HttpPost]
        public IActionResult AddNewInsulinMeasure()
        {

            string userPhone = HttpContext.Request.Form["userPhone"];
            DateTime measureDate = DateTime.Now;
            string timeOfDay = HttpContext.Request.Form["timeOfDay"];


            double insulin = double.Parse(HttpContext.Request.Form["insulin"]);

            iDatas.Add(new InsulinData(userPhone, measureDate, timeOfDay, insulin));


            return View("InsulinMeasurePageList", iDatas);


        }

        [HttpPost]
        public IActionResult AddNewCarbMeasure()
        {

            string userPhone = HttpContext.Request.Form["userPhone"];
            DateTime measureDate = DateTime.Now;
            string timeOfDay = HttpContext.Request.Form["timeOfDay"];

            double carbs = double.Parse(HttpContext.Request.Form["carbs"]);


            cDatas.Add(new CarbData(userPhone, measureDate, timeOfDay, carbs));

            return View("CarbMeasurePageList", cDatas);


        }

        /*
        [HttpPost]
        public IActionResult AddNewBS() //blood sugar
        {
            int userId = int.Parse(HttpContext.Request.Form["userId"]);
            double mgBloodSugar = double.Parse(HttpContext.Request.Form["bloodSugar"]);
            string timeOfDay = HttpContext.Request.Form["timeOfDay"];

            //adds this data to bloodSugarDatas
            bloodSugarDatas.Add(new BloodSugarData(userId, mgBloodSugar, timeOfDay));
            
            return view $$$$
        }

        [HttpPost]
        public IActionResult AddNewID() //insulin dose
        {
            int userId = int.Parse(HttpContext.Request.Form["userId"]);
            double mgInsulinDose = double.Parse(HttpContext.Request.Form["insulinDose"]);
            string timeOfDay = HttpContext.Request.Form["timeOfDay"];

            insulinData.Add(new InsulinData(userId, DateTime.Now, timeOfDay, mgInsulinDose));
        }

        [HttpPost]
        public IActionResult AddNewCM() //carbon meal
        {
            int userId = int.Parse(HttpContext.Request.Form["userId"]);
            double mgBloodSugar = double.Parse(HttpContext.Request.Form["bloodSugar"]);
            string timeOfDay = HttpContext.Request.Form["timeOfDay"];

            carbDatas.Add(new CarbData(userId, DateTime.Now, timeOfDay, grCarbIntake));
        }
        */




    };

}
