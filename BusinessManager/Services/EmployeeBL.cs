using BusinessManager.Interfaces;
using EmployeePayrollApp.Models;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Services
{
    public class EmployeeBL : IEmployeeBL
    {
        private IEmployeeRL employeeRL;

        public EmployeeBL(IEmployeeRL employeeRL)
        {
            this.employeeRL = employeeRL;
        }


        public bool RegisterEmployee(EmployeeDetails employee)
        {
            try
            {
                return this.employeeRL.RegisterEmployee(employee);
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
