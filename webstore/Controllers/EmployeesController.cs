using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webstore.Models;

namespace webstore.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IEnumerable<EmployerViewModel> _employees = new List<EmployerViewModel>
        {
            new EmployerViewModel
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22,
                Details = "Детали первого"
            },
            new EmployerViewModel
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35,
                Details = "Детали второго"
            }
        };

        public IActionResult Index()
        {
            return View(_employees);
        }


        public IActionResult Details(int id)
        {

            var employee = _employees.FirstOrDefault(t => t.Id == id);

            return View(employee);
        }

    }
}
