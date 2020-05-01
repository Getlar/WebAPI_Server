using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Server.Models
{
    public class Person
    {
        [Key]
        public int id{ get; set; }
        [Required]
        [MaxLength(40)]
        public string firstName{ get; set; }
        [MaxLength(50)]
        public string lastName{ get; set; }
        public DateTime dateOfBirth { get; set; }

    }
}
