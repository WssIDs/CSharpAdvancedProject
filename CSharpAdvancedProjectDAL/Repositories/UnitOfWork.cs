using System;
using System.Collections.Generic;
using System.Text;
using CSharpAdvancedProjectDAL.Entities;
using CSharpAdvancedProjectDAL.Interfaces;
using CSharpAdvancedProjectDAL.Interfaces.Entities;

namespace CSharpAdvancedProjectDAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IGenericRepository<Company> companyRepository,
            IGenericRepository<Position> positionRepository,
            IGenericRepository<Employee> employeeRepository)
        {
            Companies = companyRepository;
            Positions = positionRepository;
            Employees = employeeRepository;
        }

        public IGenericRepository<Company> Companies { get; }
        public IGenericRepository<Employee> Employees { get; }
        public IGenericRepository<Position> Positions { get; }
    }
}
