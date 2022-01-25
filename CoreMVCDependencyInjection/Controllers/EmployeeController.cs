using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCDependencyInjection.Respository.Contract;
using CoreMVCDependencyInjection.Models;
using CoreMVCDependencyInjection.Respository.Services;

namespace CoreMVCDependencyInjection.Controllers
{
    public class EmployeeController : Controller
    {
        public IEmployee EmployeeService { get; }
        // Injecting instance of interface IEmployee
        public EmployeeController(IEmployee _employeeService)
        {
            EmployeeService = _employeeService;
        }

        

        public IActionResult Index()
        {
            var emps = EmployeeService.GetEmployees();
            return View(emps);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            EmployeeService.CreateEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}
