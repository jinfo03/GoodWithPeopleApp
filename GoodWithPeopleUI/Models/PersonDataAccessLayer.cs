using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoodWithPeopleMainUI.Models
{
    public class PersonDataAccessLayer
    {

        GoodWithPeopleDBContext db = new GoodWithPeopleDBContext();

        public IEnumerable<Person> GetAllPersons()
        {
            try
            {
                return db.Person.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new Person record     
        public int AddPerson(Person person)
        {
            try
            {
                db.Person.Add(person);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //To Update the records of a particluar person    
        public int UpdatePerson(Person person)
        {
            try
            {
                db.Entry(person).State = EntityState.Modified;
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular person    
        public Person GetPersonData(int id)
        {
            try
            {
                Person person = db.Person.Find(id);
                return person;
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular person    
        public int DeletePerson(int id)
        {
            try
            {
                Person emp = db.Person.Find(id);
                db.Person.Remove(emp);
                db.SaveChanges();
                return 1;
            }
            catch
            {
                throw;
            }
        }
    }
}
