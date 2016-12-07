using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversitySolution
{
    public class Degree
    {
        [Key]
        public Guid DegreeId { get; set; }

        public string DegreeTitle { get; set; }

        //navigational properties

        public DegreeType DegreeType { get; set; }
        public ICollection<DegreeRequirment> DegreeRequirments { get; set; }
        public ICollection<Grade> Grades { get; set; }

    }
}
