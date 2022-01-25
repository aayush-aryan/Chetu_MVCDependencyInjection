using CoreMVCDependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVCDependencyInjection.Respository.Contract
{
    public interface IEmployee
    {
        //declearing abstract method for creating Employee
        Employee CreateEmployee(Employee employee);

        //declearing abstract method for getting employee 
        List<Employee> GetEmployees();

        //for getting total number of Employee
        int CountEmployees();
    }
}
