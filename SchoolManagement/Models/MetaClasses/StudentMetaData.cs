using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SchoolManagement.Models
{
    public class StudentMetaData
    {
        public int StudentID { get; set; }

        [StringLength(50)]
        [Display(Name = "First Name")]
        public string StudentFirstName { get; set; }

        [StringLength(50)]
        [Display(Name = "Middle Name")]
        public string StudentMiddleName { get; set; }

        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string StudentLastName { get; set; }

        [Display(Name = "Birth Date")]
        public DateTime? StudentBirthDate { get; set; }

        [Display(Name ="Date of Enrollment")]
        public DateTime? StudentEnrollmentDate { get; set; }

        
    }

    [MetadataType(typeof(StudentMetaData))]
    public partial class Student { }
}