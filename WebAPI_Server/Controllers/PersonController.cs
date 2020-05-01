using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_Server.Models;
using WebAPI_Server.Repositories;

namespace WebAPI_Server.Controllers
{
    [Route("api/person")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {
            var people = PersonRepository.GetPeople();
            return Ok(people);
        }

        [HttpGet("{id}")]

        public ActionResult<Person> Get(int id)
        {
            var person = PersonRepository.GetPerson(id);
            if (person != null)
            {
                return Ok(person);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public ActionResult Post(Person person)
        {
            PersonRepository.StorePerson(person);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(Person person,int id)
        {
            var dbperson = PersonRepository.GetPerson(id);
            if (dbperson !=null)
            {
                PersonRepository.UpdatePerson(person);
                return Ok();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePerson(int id)
        {
            var person = PersonRepository.GetPerson(id);
            if (person != null)
            {
                PersonRepository.DeletePerson(person);
                return Ok();
            }
            return NotFound();
        }
    }
}