using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesTutorial.Models;
using RazorPagesTutorial.Services;

namespace RazorPagesTutorial
{
    public class IndexModel : PageModel
    {

        private readonly IEmployeeRepository employeeRepository;

        public IEnumerable<Employee> Employees { get; set; }

        public IndexModel( IEmployeeRepository employeeReposity )
        {
            this.employeeRepository = employeeReposity;
        }


        public void OnGet()
        {
            Employees = employeeRepository.GetAllEmployees();
        }
    }
}