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

        public ActionResult<Person> Get(long id)
        {
            var people = PersonRepository.GetPeople();
            var person = people.FirstOrDefault(x => x.id == id);
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
            var people = PersonRepository.GetPeople();
            var newId = GetNewId(people);
            person.id = newId;
            people.Add(person);
            PersonRepository.StorePeople(people);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(Person person)
        {
            var people = PersonRepository.GetPeople();
            var oldPerson = people.FirstOrDefault(x => x.id == person.id);
            if (oldPerson != null)
            {
                oldPerson.firstName = person.firstName;
                oldPerson.lastName = person.lastName;
                oldPerson.dateOfBirth = person.dateOfBirth;
            }
            else
            {
                var newId = GetNewId(people);
                person.id = newId;
                people.Add(person);
            }
            PersonRepository.StorePeople(people);
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var people = PersonRepository.GetPeople();
            var peron = people.FirstOrDefault(x => x.id == id);
            if (peron != null)
            {
                people.Remove(peron);
                PersonRepository.StorePeople(people);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        private int GetNewId(IList<Person> people)
        {
            int id = 0;

            foreach (var person in people)
            {
                if(id < person.id)
                {
                    id = person.id;
                }
            }

            return id + 1;
        }
    }
}