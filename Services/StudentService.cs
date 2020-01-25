using Models;
using Repository;
using Repository.Pattern;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public interface IStudentService : IService<Student>
    {

    }

    public class StudentService : Service<Student>, IStudentService
    {
        public StudentService(IStudentRepository repository) : base(repository)
        {
        }
    }
}
