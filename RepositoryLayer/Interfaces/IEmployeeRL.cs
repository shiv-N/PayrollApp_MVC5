﻿using EmployeePayrollApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IEmployeeRL
    {
        bool RegisterEmployee(EmployeeDetails employee);
    }
}
