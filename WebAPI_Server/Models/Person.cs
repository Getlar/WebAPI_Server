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
        public int Id{ get; set; }
        [Required]
        public DateTime DateOfArrival { get; set; }
        [Required]
        [MaxLength(20)]
        public string FirstName{ get; set; }
        [Required]
        [MaxLength(20)]
        public string LastName{ get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set;}
        [Required]
        [MaxLength(11)]
        public string SocialSecurityNumber { get; set; }
        [Required]
        [MaxLength(200)]
        public string Complaint { get; set; }

        [MaxLength(200)]
        public string Diagnosis { get; set; }

    }
}
