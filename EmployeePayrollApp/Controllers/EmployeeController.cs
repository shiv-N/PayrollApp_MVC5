using BusinessManager.Interfaces;
using EmployeePayrollApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeePayrollApp.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeBL employeeBL;
        public EmployeeController(IEmployeeBL employeeBL)
        {
            this.employeeBL = employeeBL;
        }

        // GET: Employee
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(EmployeeDetails employee)
        {
            try
            {
                bool result = this.employeeBL.RegisterEmployee(employee);
                if(result == true)
                {
                    return RedirectToAction("EmployeeDetail", employee);
                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Details()
        {
            List<EmployeeDetails> employees =  GetEmployeeData();

            return View(employees);
        }

        private static List<EmployeeDetails> GetEmployeeData()
        {
            List<EmployeeDetails> employees = new List<EmployeeDetails>()
            {
                new EmployeeDetails()
                {
                    Name = "Saurabh",
                    Gender = "Male",
                    Department = new DepartmentList()
                    {
                        IsEngineer = true,
                        IsFinance = true,
                        IsHR = true
                    },
                    ProfileImage = "Image1.jpg",
                    Salary = 50000,
                    StartDate = DateTime.Now,
                    Notes = "record 1"
                },
                new EmployeeDetails()
                {
                    Name = "Lavanya",
                    Gender = "Female",
                    Department = new DepartmentList()
                    {
                        IsEngineer = true,
                        IsFinance = true,
                        IsHR = true
                    },
                    ProfileImage = "Image2.jpg",
                    Salary = 50000,
                    StartDate = DateTime.Now,
                    Notes = "record 2"
                }
            };
            return employees;
        }
    }
}