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
        Task CreateAsync(PositionModel position);
    }
}
