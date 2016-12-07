using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversitySolution
{
    public class Course
    {
        [Key]
        public Guid CourseId { get; set; }

        public string CourseTitle { get; set; }

        public string CourseDescription { get; set; }

        public double Credit { get; set; }

        #region Navigarional properties

        public ICollection<Degree> Degrees { get; set; }
        public ICollection<Student> Students { get; set; }
        public Department Department { get; set; }
        #endregion

    }
}
