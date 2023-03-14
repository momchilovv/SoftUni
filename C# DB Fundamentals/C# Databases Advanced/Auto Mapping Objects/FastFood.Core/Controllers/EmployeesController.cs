namespace FastFood.Core.Controllers
{
    using System;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Data;
    using FastFood.Models;
    using Microsoft.AspNetCore.Mvc;
    using ViewModels.Employees;

    public class EmployeesController : Controller
    {
        private readonly FastFoodContext context;
        private readonly IMapper mapper;

        public EmployeesController(FastFoodContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public IActionResult Register()
        {
            var positions = context.Positions
                .ProjectTo<RegisterEmployeeViewModel>(mapper.ConfigurationProvider)
                .ToList();

            return View(positions);
        }

        [HttpPost]
        public IActionResult Register(RegisterEmployeeInputModel model)
        {
            var employee = mapper.Map<Employee>(model);

            context.Employees.Add(employee);

            context.SaveChanges();

            return RedirectToAction("All", "Employees");
        }

        public IActionResult All()
        {
            var employees = context.Employees
                .ProjectTo<EmployeesAllViewModel>(mapper.ConfigurationProvider)
                .ToList();

            return View(employees);
        }
    }
}
