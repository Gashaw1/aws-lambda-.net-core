using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWSSLambdaEmployeeListWebAPI.Models;

namespace AWSSLambdaEmployeeListWebAPI.Services
{
    public class EmployeeListService : IEmployeeListService
    {
        private readonly Dictionary<int, string> listOfEmployee = new Dictionary<int, string>();

        public void AddEmployee(Employee emp)
        {
            listOfEmployee.Add(emp.EmployeeId, emp.EmployeeName);
            //throw new NotImplementedException();
        }
        //return all employee
        public Dictionary<int, string> GetAllEmployeeFromTheList()
        {
            return listOfEmployee;
        }
        //delete emp by id
        //return true if delted
        public string DeleteEmployeeById(int id)
        {
            string message = "";
            bool result = false;
            result = listOfEmployee.Remove(id);   
            if(result == true)
            {
                message = "Employee with this " + id + " has been deleted";
            }
            else
            {
                message = "No employee found with this " + id + "!";
            }
            return message;
        }

       
    }
}
