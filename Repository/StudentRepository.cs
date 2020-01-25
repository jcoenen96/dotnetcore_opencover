using Microsoft.EntityFrameworkCore;
using Models;
using Repository.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IStudentRepository : IRepository<Student>
    {

    }

    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
