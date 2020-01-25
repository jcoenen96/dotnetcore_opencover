using Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repository.Tests
{
    [TestClass]
    public class SchoolRepositoryTests
    {
        public ISchoolRepository schoolRepository;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase("OpenCover")
            .Options;

            var context = new ApplicationDbContext(options);
            context.Schools.Add(new School() { Name = "Test1" });
            context.Schools.Add(new School() { Name = "Test2" });
            context.SaveChanges();


            schoolRepository = new SchoolRepository(context);
        }

        [TestMethod]
        public async Task GetAll_Good()
        {
            List<School> schools = await schoolRepository.GetAll();
            Assert.AreEqual(2, schools.Count);
        }
    }
}
