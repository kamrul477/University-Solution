using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UniversitySolution
{
    public class Application
    {
        [Key]
        public Guid ApplicationId { get; set; }

        [Display(Name = "First Name")]
        public string FristName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Gender { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        public string City { get; set; }
        public string State { get; set; }

        [Display(Name = "Postal Code")]
        public int PostCode { get; set; }

        [Display(Name = "Telephone or Mobile No")]
        public int TelephoneNo { get; set; }

        public string Email { get; set; }

        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }


        public double CGPA { get; set; }

        [Display(Name = "Sat Math Score")]
        public double SatMathScore { get; set; }

        [Display(Name = "Sat Reading Score")]
        public double SatReadingScore { get; set; }

        [Display(Name = "Sat Writting Score")]
        public double SatWrittingScore { get; set; }

        [Display(Name = "Application Receieved Date")]
        public DateTime ReceivedDate { get; set; }

        public ApplicationStatus ApplicationStaus { get; set; }


        //navigation properties

        public virtual ICollection<Session> Termses { get; set; }


    }
}
