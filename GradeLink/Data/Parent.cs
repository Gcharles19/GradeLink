using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeLink.Data
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }
        public string ParentNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Mobile { get; set; }
        public int DistrictID { get; set; }
        public string Village { get; set; }
        public DateTime DateCreated { get; set; }
        public int StatusID { get; set; }
        public string Password { get; set; }
    }
}
