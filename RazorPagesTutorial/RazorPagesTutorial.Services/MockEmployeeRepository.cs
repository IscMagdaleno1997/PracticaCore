using RazorPagesTutorial.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RazorPagesTutorial.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {

        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Mary", Departament = Dept.HR, Email = "a@a.com", Photopath="LogoBlanco.png" },
                new Employee(){ Id = 1, Name = "John", Departament = Dept.HR, Email = "b@b.com", Photopath="LogoBlanco2.png" },
                new Employee(){ Id = 1, Name = "Jane", Departament = Dept.HR, Email = "c@c.com", Photopath="LogoN-Edit.png" },
                new Employee(){ Id = 1, Name = "Peter", Departament = Dept.HR, Email = "e@e.com", Photopath="LogoRolando.png" }

            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
