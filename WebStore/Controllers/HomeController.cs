using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> _Employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Surname = "Иванов",
                Name = "Василий",
                Patronymus = "Перович",
                Age = 23,
                Position = "Администратор"
            },

            new Employee
            {
                Id = 2,
                Surname = "Петров",
                Name = "Иван",
                Patronymus = "Васильевич",
                Age = 25,
                Position = "Администратор"
            },

            new Employee
            {
                Id = 3,
                Surname = "Васильев",
                Name = "Пётр",
                Patronymus = "Иванович",
                Age = 22,
                Position = "Администратор"
            }
        };
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View(_Employees);
        }

        public IActionResult Employee(int id)
        {
            var employee = _Employees.FirstOrDefault(e => e.Id == id);
            if (employee is null)
                return NotFound();
            return View(employee);
        }
    }
}