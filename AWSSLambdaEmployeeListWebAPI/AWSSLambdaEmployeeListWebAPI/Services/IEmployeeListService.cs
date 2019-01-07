using System.Collections.Generic;
using AWSSLambdaEmployeeListWebAPI.Models;

namespace AWSSLambdaEmployeeListWebAPI.Services
{
    public interface IEmployeeListService
    {
        Dictionary<int, string> GetAllEmployeeFromTheList();
        void AddEmployee(Employee employee);
        string DeleteEmployeeById(int id);
       

    }
}