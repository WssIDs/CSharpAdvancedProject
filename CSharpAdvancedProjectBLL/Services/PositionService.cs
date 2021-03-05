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
    public class PositionService : IPositionService
    {
        private readonly IUnitOfWork _database;

        private readonly IMapper _mapper;

        public PositionService(IUnitOfWork database)
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

        public async Task<IEnumerable<PositionModel>> GetAllAsync()
        {
            return _mapper.Map<IEnumerable<PositionModel>>(await _database.Positions.GetAll().ToListAsync());
        }

        public async Task CreateAsync(PositionModel position)
        {
            await _database.Positions.CreateAsync(_mapper.Map<Position>(position));
        }
    }
}
