using BlqhLab06.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BlqhLab06.Controllers
{
    public class BlqhEmployeeController : Controller
    {
        private static List<BlqhEmployee> blqhlistEmployee = new List<BlqhEmployee>()
        {
            new BlqhEmployee
            {
                BlqhId = 1,
                BlqhName = "Bùi Lê Quốc Hùng",
                BlqhBirthDay = new DateTime(2005, 2, 14),
                BlqhEmail = "quochungb3@gmail.com",
                BlqhPhone = "0327048118",
                BlqhSalary = 100000000,
                BlqhStatus = true
            },
            new BlqhEmployee
            {
                BlqhId = 2,
                BlqhName = "Trần Thị B",
                BlqhBirthDay = new DateTime(1995, 11, 10),
                BlqhEmail = "tranthib@example.com",
                BlqhPhone = "0912345678",
                BlqhSalary = 12000000,
                BlqhStatus = true
            },
            new BlqhEmployee
            {
                BlqhId = 3,
                BlqhName = "Lê Văn C",
                BlqhBirthDay = new DateTime(1988, 2, 15),
                BlqhEmail = "levanc@example.com",
                BlqhPhone = "0939876543",
                BlqhSalary = 18000000,
                BlqhStatus = false
            },
            new BlqhEmployee
            {
                BlqhId = 4,
                BlqhName = "Phạm Thị D",
                BlqhBirthDay = new DateTime(1992, 8, 5),
                BlqhEmail = "phamthid@example.com",
                BlqhPhone = "0977654321",
                BlqhSalary = 14000000,
                BlqhStatus = true
            },
            new BlqhEmployee
            {
                BlqhId = 5,
                BlqhName = "Đỗ Văn E",
                BlqhBirthDay = new DateTime(1985, 1, 30),
                BlqhEmail = "dovane@example.com",
                BlqhPhone = "0988765432",
                BlqhSalary = 20000000,
                BlqhStatus = false
            }
        };

        public IActionResult BlqhIndex()
        {
            return View(blqhlistEmployee); 
        }
        public IActionResult BlqhCreate()
        {
            return View();
        }
    }
}
