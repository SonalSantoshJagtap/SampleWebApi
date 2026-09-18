using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SampleWebAPI.Models;

namespace SampleWebAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentAPIController : ControllerBase
    {
        WebApiDbContext db;

        public StudentAPIController(WebApiDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        [Route("api/Students")]
        public List<Student> GetAll()
        {
            List<Student> lst = db.Students.ToList();
            return lst;
        }

        [HttpGet]
        [Route("api/Students/{id}")]
        public Student GetById(int id)
        {
            return db.Students.Find(id);
        }

        [HttpPost]
        [Route("api/Students")]

        public Student AddStudent(Student st)
        {
            db.Students.Add(st);
            db.SaveChanges();
            return st;
        }

        [HttpPut]
        [Route("api/Students")]
        public Student UpdateStudentDetails(Student st)
        {
            db.Students.Update(st);
            db.SaveChanges();
            return st;
        }

        [HttpDelete]
        [Route("api/Students")]
        public Student DeleteStudent(Student st)
        {
            db.Students.Remove(st);
            db.SaveChanges();
            return st;

        }
    }
}
