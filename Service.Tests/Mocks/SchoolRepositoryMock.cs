using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Tests.Mocks
{
    public class SchoolRepositoryMock : ISchoolRepository
    {
        public List<School> schools = new List<School>();

        public SchoolRepositoryMock()
        {
            schools = new List<School>();
        }

        public void Add(School entity)
        {
            schools.Add(entity);
        }

        public void AddRange(IEnumerable<School> entities)
        {
            throw new NotImplementedException();
        }

        public School Find(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<School>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(School entity)
        {
            throw new NotImplementedException();
        }

        public void Update(School entity)
        {
            throw new NotImplementedException();
        }
    }
}
