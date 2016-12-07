using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversitySolution
{
    public class Session
    {
        [Key]
        public Guid SessionId { get; set; }

        public DateTime SessionStarYear { get; set; }
        public DateTime SessionEndYear { get; set; }

    }
}
