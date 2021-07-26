using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ApiTask2.Models;
using ApiTask2.Controllers;

namespace ApiTask2.Controllers
{
    public class TestController : ApiController
    {
        ITIContext db = new ITIContext();
        public IHttpActionResult getAll()
		{
            return Ok(db.Students.ToList());
		}
    }
}
