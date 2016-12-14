using Domain.UniversitySolution;
using MySql.Data.Entity;
using System.Data.Entity;

namespace DataLayer.UniversitySolution
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class UniversityContext : DbContext
    {
        public UniversityContext() : base("DefaultConnection")
        {

        }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<DegreeRequirment> DegreeRequirments { get; set; }
        public DbSet<DegreeType> DegreeTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<FacultyMember> FacultyMembers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<University> Universities { get; set; }
    }
}
