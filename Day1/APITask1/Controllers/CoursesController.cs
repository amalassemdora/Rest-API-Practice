using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using APITask1.Models;
namespace APITask1.Controllers
{
    public class CoursesController : ApiController
    {
        List<Course> Courses = new List<Course>()
        {
            new Course(){Id=1,Name="C#",Duration=60,Description="Intro to >net and C# basics."},
            new Course(){Id=2,Name="SQL",Duration=50,Description="Structure query language."},
            new Course(){Id=3,Name="ASP.NET",Duration=36,Description="Server side programming."},
            new Course(){Id=4,Name="MVC",Duration=30,Description="Server side programming."},
        };
        public IHttpActionResult get()
		{
			if (Courses == null)
			{
                return NotFound();
			}
			else
			{
                return OK(Courses);
            }        
		}
        public IHttpActionResult  getById(int id)
        {
            Course crs = Courses.Find(n => n.Id == id);

            if (crs == null)
            {
                return NotFound();
            }
            else
            {
                return OK(crs);
            }
            
        }
        [Route("API/Crs/{name}")]
        [HttpGet]
        public IHttpActionResult CourseByName (string name)
        {
            Course crs = Courses.Find(n => n.Name == name);
            if (crs == null)
            {
                return NotFound();
            }
            else
            {
                return OK(crs);
            }
        }
        public IHttpActionResult post(Course crs)
		{
            if (crs == null)
            {
                return BadRequest()));
            }
            else
            {
                Courses.Add(crs);

                return Created("Success", Courses);
            }
		}
        public IHttpActionResult put(int id,Course c)
		{
            if (c == null)
              return BadRequest();
            Course crs = Courses.Find(n => n.Id == id);
            if (crs == null)
                return NotFound();
            crs.Id = c.Id;
            crs.Name = c.Name;
            crs.Duration = c.Duration;
            crs.Description = c.Description;
            return StatusCode(HttpStatusCode.NoContent);
        }
        [HttpDelete]
        public IHttpActionResult deleteCourse(int id)
		{
            Course crs = Courses.Find(n => n.Id == id);
            if (crs == null)
                return NotFound();  
            Courses.Remove(crs);
            return Ok(Courses);
        }
    }

}
