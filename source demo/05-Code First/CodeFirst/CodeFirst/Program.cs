using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Repositories;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatePerson();
            CreatePerson();
        }

        static void CreatePerson()
        {
            Person person = new Person();
            Console.Write("First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            person.LastName = Console.ReadLine();

            PersonRepository personRepository = new PersonRepository();
            personRepository.Create(person);
        }
    }
}
