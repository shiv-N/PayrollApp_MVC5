using EmployeePayrollApp.Models;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Services
{
    public class EmployeeRL : IEmployeeRL
    {
        string connectionString = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
        

        public bool RegisterEmployee(EmployeeDetails employee)
        {
            //create new sqlconnection and connection to database by using connection string from web.config file  
            SqlConnection connection = new SqlConnection(connectionString);
            
            throw new NotImplementedException();
        }
    }
}
