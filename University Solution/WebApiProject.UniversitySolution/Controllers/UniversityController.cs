using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiProject.UniversitySolution.Controllers
{
    public class UniversityController : ApiController
    {
        // GET: api/University
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/University/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/University
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/University/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/University/5
        public void Delete(int id)
        {
        }
    }
}
