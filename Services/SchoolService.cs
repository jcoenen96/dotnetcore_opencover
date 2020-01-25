using Models;
using Repository;
using Repository.Pattern;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services
{
    public interface ISchoolService : IService<School>
    {
        Task<List<School>> GetAll();
    }

    public class SchoolService : Service<School>, ISchoolService
    {
        private readonly ISchoolRepository _schoolRepository;

        public SchoolService(ISchoolRepository repository) : base(repository)
        {
            _schoolRepository = repository;
        }

        public Task<List<School>> GetAll()
        {
            return _schoolRepository.GetAll();
        }
    }
}
