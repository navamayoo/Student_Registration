using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Registration.Data;

namespace Student_Registration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public StudentController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}
