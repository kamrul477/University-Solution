using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.UniversitySolution;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApi.UniversitySolution;

namespace DataLayer.UniversitySolution
{
    public class UniversityContext : DbContext
    {
        
        public DbSet<Application> Applications { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<DegreeRequirment> DegreeRequirments { get; set; }
        public DbSet<DegreeType> DegreeTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FacultyMember> FacultyMembers { get; set; }
        public DbSet<Grade> Grades { get; set; } 
        public DbSet< Session> Sessions { get; set; }
        public DbSet< Student> Students { get; set; }  
        public DbSet<University> Universities { get; set; }
    }
}
