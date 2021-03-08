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
        Task CreateAsync(EmployeeModel company);
        Task<EmployeeModel> GetAsync(int id);
        Task UpdateAsync(EmployeeModel employee);
        Task DeleteAsync(int id);
    }
}
