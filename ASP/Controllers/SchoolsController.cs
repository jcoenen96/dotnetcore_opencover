using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models;
using Services;

namespace OpenCover.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolsController : ControllerBase
    {
        private readonly ILogger<SchoolsController> _logger;
        private readonly ISchoolService _schoolService;

        public SchoolsController(
            ILogger<SchoolsController> logger,
            ISchoolService schoolService)
        {
            _logger = logger;
            _schoolService = schoolService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            List<School> schools = await _schoolService.GetAll();
            if (!schools.Any())
            {
                return NotFound();
            }
            return Ok(schools);
        }
    }
}
