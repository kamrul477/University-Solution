using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.UniversitySolution;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DataLayer.UniversitySolution
{
    public class UniversityContext : DbContext
    {
        public DbSet<Application> Applications { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<DegreeRequirment> DegreeRequirments { get; set; }
    }
}
