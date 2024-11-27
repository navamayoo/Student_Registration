using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Registration.Data;
using Student_Registration.Module;

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

                [HttpPost]
        public ActionResult<Student>Create([FromBody]Student student)
        {
            _appDbContext.Students.Add(student);
            _appDbContext.SaveChanges();
            return Ok(student);
        }

        [HttpGet]
        public ActionResult <IEnumerable<Student>> GetAll()
        {
            return _appDbContext.Students.ToList();
        }

        [HttpGet("{id:int}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = _appDbContext.Students.Find(id);
            return Ok(student);
        }

    }
}
