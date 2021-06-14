using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GradeLink.Data
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Name { get; set; }
        [ForeignKey("StausID")]
        public Status Status { get; set; }
        public int StausID { get; set; }
    }
}
