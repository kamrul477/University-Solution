using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversitySolution
{
    public class DegreeType
    {
        [Key]
        public Guid DegreeTypeId { get; set; }

        [Display(Name="Type of Degree")]
        public string DegreeTypeTitle { get; set; }


        //navigational properties
        public virtual ICollection<Degree> Degrees { get; set; }

    }
}
