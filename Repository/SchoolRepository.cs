using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Pattern;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository
{
    public interface ISchoolRepository : IRepository<School>
    {
        Task<List<School>> GetAll();
    }

    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        public SchoolRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<School>> GetAll()
        {
            return GetDbSet<School>().ToListAsync();
        }
    }
}
