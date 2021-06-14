using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeLink.Data
{
    public class Staff
    {
        [Key]
        public int Id { get; set; }
        public int StaffTypeID { get; set; }
        [Required]
        public string SatffNo { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Telphone { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public byte[] Photo { get; set; }
        public int StatusID { get; set; }
    }
}
