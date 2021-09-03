using EmployeePayrollApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManager.Interfaces
{
    public interface IEmployeeBL
    {
        bool RegisterEmployee(EmployeeDetails employee);
    }
}
