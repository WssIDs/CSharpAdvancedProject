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
    public interface ICompanyService
    {
        Task<CompanyModel> GetAsync(int id);
        Task<IEnumerable<CompanyModel>> GetAllAsync();
        Task UpdateAsync(CompanyModel company);
        Task CreateAsync(CompanyModel company);
    }
}
