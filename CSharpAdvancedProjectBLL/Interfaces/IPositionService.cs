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
    public interface IPositionService
    {
        Task<IEnumerable<PositionModel>> GetAllAsync();
        Task<PositionModel> GetAsync(int id);
        Task CreateAsync(PositionModel position);
        Task UpdateAsync(PositionModel position);
        Task DeleteAsync(int id);
    }
}
