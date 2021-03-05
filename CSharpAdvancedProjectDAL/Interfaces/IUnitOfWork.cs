using System;
using CSharpAdvancedProjectDAL.Entities;
using CSharpAdvancedProjectDAL.Interfaces.Entities;

namespace CSharpAdvancedProjectDAL.Interfaces
{
    public interface IUnitOfWork
    {
        IGenericRepository<Company> Companies { get; }
        IGenericRepository<Employee> Employees { get; }
        IGenericRepository<Position> Positions { get; }
    }
}
