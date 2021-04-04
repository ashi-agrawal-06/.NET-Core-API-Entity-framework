using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assignmentproject.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }

        public int Roll_No { get; set;  }
        [Required]
        [MaxLength(50, ErrorMessage = "Name can only be 50 char long")]
        public string F_Name { get; set; }

        public string L_Name { get; set; }
    }
}
