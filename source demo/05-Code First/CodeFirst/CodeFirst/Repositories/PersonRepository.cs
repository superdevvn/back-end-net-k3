using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repositories
{
    public class PersonRepository
    {
        // CRUD
        // Create
        public Person Create(Person person)
        {
            using (var context = new SuperDevDbContext())
            {
                person.Id = Guid.NewGuid();
                context.Persons.Add(person);
                context.SaveChanges();
                return context.Persons.Find(person.Id);
            }
        }

        // Get List
        public List<Person> GetList()
        {
            using (var context = new SuperDevDbContext())
            {
                return context.Persons.ToList();
            }
        }

        // Get by id
        public Person GetById(Guid id)
        {
            using (var context = new SuperDevDbContext())
            {
                return context.Persons.Find(id);
            }
        }

        // Update
        public Person Update(Person person)
        {
            using (var context = new SuperDevDbContext())
            {
                Person personTrongDatabase = context.Persons.Find(person.Id);
                personTrongDatabase.FirstName = person.FirstName;
                personTrongDatabase.LastName = person.LastName;
                context.SaveChanges();
                return context.Persons.Find(person.Id);
            }
        }

        // Delete
        public void Delete(Guid id)
        {
            using (var context = new SuperDevDbContext())
            {
                Person person = context.Persons.Find(id);
                context.Persons.Remove(person);
                context.SaveChanges();
            }
        }
    }
}
