using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace BloodSugar.Models
{
    public partial class UserInfo
    {

        public string Name { get; set; }

        public string Address { get; set; }

        [Unicode]
        public string Phone { get; set; }

        public DateTime BirthDay { get; set; }

        public UserInfo(string name, string address, string phone, DateTime birthDay)
        {

            Name = name;
            Address = address;
            Phone = phone;
            BirthDay = birthDay;
        }

    }

}