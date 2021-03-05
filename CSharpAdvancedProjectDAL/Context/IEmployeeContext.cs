using CSharpAdvancedProjectDAL.Entities;
using CSharpAdvancedProjectDAL.Interfaces.Entities;
using Microsoft.EntityFrameworkCore;

namespace CSharpAdvancedProjectDAL.Context
{
    public interface IEmployeeContext
    {
        DbSet<Employee> Employees { get; set; }
        DbSet<Company> Companies { get; set; }
        DbSet<Position> Positions { get; set; }
    }
}
