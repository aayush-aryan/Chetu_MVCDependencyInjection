using CoreMVCDependencyInjection.Models;
using CoreMVCDependencyInjection.Respository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCDependencyInjection.Respository.Services
{
    public class EmployeeService : IEmployee
    {
        // declearing a variable Employees as a List type
        private List<Employee> Employees;

        public EmployeeService()
        {
            //initialzing Employees variable for storing List of Employee inside constructor
            Employees = new List<Employee>() { 
                //static record
                new Employee(){Id=1,Name="Aayush",Email="aayush@gmail.com",Gender="Male"},
                new Employee(){Id=2,Name="Aryan",Email="aryan@gmail.com",Gender="Male"},
                new Employee(){Id=3,Name="Ankit",Email="ankit@gmail.com",Gender="Male"},
                new Employee(){Id=4,Name="Charu",Email="charu@gmail.com",Gender="Female"},
                new Employee(){Id=5,Name="Apurva",Email="apurva@gmail.com",Gender="Male"},

             };
        }

        public int CountEmployees()
        {
            return Employees.Count;
        }

        public Employee CreateEmployee(Employee employee)
        {
            employee.Id = Employees.Count + 1;
            Employees.Add(employee);

            return employee;
        }

        //public List<Employee> CreateEmployee(Employee employee)
        //{
        //    Employees.Add(employee);

        //    return employee;
        //}

        public List<Employee> GetEmployees()
        {
            return Employees.ToList();
        }
    }
}
