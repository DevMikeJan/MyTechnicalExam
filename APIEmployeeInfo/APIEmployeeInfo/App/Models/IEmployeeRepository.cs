using System;
using System.Data;
using System.Threading.Tasks;
using static APIEmployeeInfo.Public.CustomEnums;

namespace APIEmployeeInfo.App.Models
{
    public interface IEmployeeRepository
    {

        Task<DataTable> LoadList();
        Task<String> GetEmpID();

        Task<Boolean> SaveInfo(EmployeeModel ListInput, Trans trans);
        Task<Boolean> DelEmp(string empID);
    }
}
