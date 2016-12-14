using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


namespace Domain.UniversitySolution
{
    public class University
    {
        [Key]
        public Guid  UniversityId { get; set; }
        public string UnivesityName { get; set; }
        public string UniversitySlogan { get; set; }
     
        #region Navigation Properties

        public ICollection<Student> Students { get; set; }
        public ICollection<Department> Departments { get; set; }

        #endregion


    }
}
