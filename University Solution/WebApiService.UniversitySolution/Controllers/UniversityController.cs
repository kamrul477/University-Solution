﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using DataLayer.UniversitySolution;
using Domain.UniversitySolution;

namespace WebApiService.UniversitySolution
{
    [EnableCors("*", "*", "*")]
    public class UniversityController : ApiController
    {
        private readonly UniversityContext _context = new UniversityContext();
        // GET: api/University
        public IEnumerable<University> Get()
        {
            var universityList = _context.Universities.ToList();
            return universityList;
        }

        // GET: api/University/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/University
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/University/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/University/5
        public void Delete(int id)
        {
        }
    }
}