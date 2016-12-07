using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversitySolution
{
    public class DegreeRequirment
    {
        [Key]
        public Guid DegreeRequirmentId { get; set; }




        //navigational property
        public Degree Degree { get; set; }

    }
}
