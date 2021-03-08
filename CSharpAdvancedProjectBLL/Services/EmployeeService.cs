using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CSharpAdvancedProjectBLL.Interfaces;
using CSharpAdvancedProjectBLL.Models;
using CSharpAdvancedProjectDAL.Entities;
using CSharpAdvancedProjectDAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CSharpAdvancedProjectBLL.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly IUnitOfWork _database;

        private readonly IMapper _mapper;

        public EmployeeService(IUnitOfWork database)
        {
            _database = database;

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Company, CompanyModel>().ReverseMap();
                cfg.CreateMap<Employee, EmployeeModel>().ReverseMap();
                cfg.CreateMap<Position, PositionModel>().ReverseMap();
            });

            _mapper = configuration.CreateMapper();
        }

        public async Task<IEnumerable<EmployeeModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<EmployeeModel>>(await _database.Employees.GetAll()
                .Include(emp => emp.Company)
                .Include(emp => emp.Position)
                .ToListAsync());
        }

        public async Task CreateAsync(EmployeeModel employee)
        {
            await _database.Employees.CreateAsync(_mapper.Map<Employee>(employee));
        }

        public async Task<EmployeeModel> GetAsync(int id)
        {
            return _mapper.Map<EmployeeModel>(await _database.Employees.GetAsync(id));
        }

        public async Task UpdateAsync(EmployeeModel employee)
        {
            await _database.Employees.UpdateAsync(_mapper.Map<Employee>(employee));
        }

        public async Task DeleteAsync(int id)
        {
            await _database.Employees.DeleteAsync(id);
        }
    }
}
