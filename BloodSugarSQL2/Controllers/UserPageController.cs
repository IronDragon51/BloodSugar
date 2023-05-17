using BloodSugar.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BloodSugar.Controllers
{
    public class UserPageController : Controller
    {

        public static List<UserInfo> userInfos = new List<UserInfo>()
        {
            new UserInfo("Jesse", "123 Main St", "555-234-7443", new DateTime(1984, 6, 3)),
            new UserInfo("Mike", "453 Hudson St", "555-777-3333", new DateTime(1974, 3, 8)),
            new UserInfo("Walt", "123 Main St", "155-234-7343", new DateTime(1972, 6, 11)),
            new UserInfo("Saul", "123 Main St", "555-234-7443", new DateTime(1970, 6, 3)),
            new UserInfo("Hank", "123 Main St", "555-234-7443", new DateTime(1964, 6, 3)),
            new UserInfo("Gus", "123 Main St", "555-234-7443", new DateTime(1962, 6, 3)),
            new UserInfo("Skyler", "123 Main St", "555-234-7443", new DateTime(1960, 6, 3)),


        };



        public IActionResult AddUser()
        {
            return View();
        }

        public IActionResult UserPageList()
        {
            return View(userInfos);
        }



        [HttpPost]
        public IActionResult AddNewUser() //from UserPage.AddUser
        {

            string name = HttpContext.Request.Form["name"];
            string address = HttpContext.Request.Form["address"];
            string phone = HttpContext.Request.Form["phone"];
            DateTime birthDay = DateTime.Parse(HttpContext.Request.Form["birthDay"]);


            userInfos.Add(new UserInfo(name, address, phone, birthDay));

            return View("UserPageList", userInfos);

            /*
            Datas datas = new Datas();
            UserInfo userInfos = new UserInfo();

            userInfos.Name = name;
            userInfos.Address = address;
            userInfos.Phone = phone;
            userInfos.BirthDay = birthDay;
             */


        }















    }
}
