
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models;
using Service.Tests.Mocks;
using Services;

namespace Service.Tests
{
    [TestClass]
    public class SchoolServiceTests
    {
        public ISchoolService schoolService;

        // Mocking repository
        public SchoolRepositoryMock schoolRepository;

        [TestInitialize]
        public void Setup()
        {
            schoolRepository = new SchoolRepositoryMock();
            schoolRepository.schools.Clear();

            schoolService = new SchoolService(schoolRepository);
        }

        [TestMethod]
        public void AddTest()
        {
            schoolService.Add(new School() { Name = "TestSchool" });
            Assert.AreEqual(1, schoolRepository.schools.Count);
        }
    }
}
