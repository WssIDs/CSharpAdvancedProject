using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvancedProjectBLL.Models;

namespace CSharpAdvancedProjectBLL.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeModel>> GetAllAsync();
        Task Create(EmployeeModel company);
        Task<EmployeeModel> GetAsync(int id);
    }
}
