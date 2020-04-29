using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Server.Models
{
    public class Person
    {

        public int id{ get; set; }
        public string firstName{ get; set; }
        public string lastName{ get; set; }
        public DateTime dateOfBirth { get; set; }

    }
}
