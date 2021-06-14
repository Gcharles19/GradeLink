using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeLink.Data
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StudentNo { get; set; }
        public string FullName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public int DistrictID { get; set; }
        public string Village { get; set; }
        public string PlaceOfBirth { get; set; }
        public int ParentID { get; set; }
        public int StatusID { get; set; }
        public byte[] Photo { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
