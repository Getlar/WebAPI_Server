using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using WebAPI_Server.Models;

namespace WebAPI_Server.Repositories
{
    public static class PersonRepository
    {
        public static IList<Person> GetPeople()
        {
            using (var database = new PersonContext())
            {
                var people = database.People.ToList();
                return people;
            };
        }

        public static Person GetPerson(int id)
        {
            using (var database = new PersonContext())
            {
                var person = database.People.Where(p => p.Id == id).FirstOrDefault();
                return person;
            };
        }

        public static void StorePerson(Person person)
        {
            using (var database = new PersonContext())
            {
                database.People.Add(person);
                database.SaveChanges();
            };
        }
        public static void UpdatePerson(Person person)
        {
            using (var database = new PersonContext())
            {

                database.People.Update(person);
                database.SaveChanges();

            };
        }
        public static void DeletePerson(Person person)
        {
            using (var database = new PersonContext())
            {
                database.People.Remove(person);
                database.SaveChanges();
            };
        }
    }
}
