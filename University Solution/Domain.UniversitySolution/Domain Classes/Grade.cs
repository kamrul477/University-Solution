using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversitySolution
{
    public class Grade
    {
        [Key]
        public Guid GradeId { get; set; }



        //navigational property
        public Degree Degree { get; set; }



    }
}
