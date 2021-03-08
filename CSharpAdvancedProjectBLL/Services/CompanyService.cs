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
    public class CompanyService : ICompanyService
    {
        private readonly IUnitOfWork _database;

        private readonly IMapper _mapper;

        public CompanyService(IUnitOfWork database)
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

        public async Task<CompanyModel> GetAsync(int id)
        {
            return _mapper.Map<CompanyModel>(await _database.Companies.GetAsync(id));
        }

        public async Task<IEnumerable<CompanyModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<CompanyModel>>(await _database.Companies.GetAll()
                .Include(c => c.Employees).ToListAsync());
        }

        public async Task UpdateAsync(CompanyModel company)
        {
            await _database.Companies.UpdateAsync(_mapper.Map<Company>(company));
        }

        public async Task CreateAsync(CompanyModel company)
        {
            await _database.Companies.CreateAsync(_mapper.Map<Company>(company));
        }

        public async Task DeleteAsync(int id)
        {
            await _database.Companies.DeleteAsync(id);
        }
    }
}
