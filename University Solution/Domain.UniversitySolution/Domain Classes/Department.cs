using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.UniversitySolution
{
    public class Department
    {
        [Key]
        public Guid DepartmentId { get; set; }

        [Display(Name = "Department Name")]
        public string NameOfDepartment { get; set; }



        #region Navigational Properties

        public ICollection<Course> Courses { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<FacultyMember> FacultyMembers { get; set; }


        #endregion

        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
        //public Guid DepartmentId { get; set; }
    }
}
