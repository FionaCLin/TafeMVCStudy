using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    class Facade
    {
        private PersonDBEntities _context = new PersonDBEntities();
        #region Person
        public Person FetchPerson(Guid id)
        {
            var result = _context.People.Find(id);
            if(result == null)
            {
                throw new Exception("Invalid Id supplied.");
            }
            return result;
        }
        public Person FetchPerson(string name)
        {
            return People.Where(p => p.Name.Equals(name)).FirstOrDefault();
        }

        public List<Person> People
        {
            get
            {
                return _context.People.ToList();
            }
        }
        public Person AddPerson(string name)
        {
            var person = new Person { Name = name };
            _context.People.Add(person);
            int result = _context.SaveChanges();
            return person;
        }
        public Person UpdatePerson(Guid id,string name)
        {
            var person = _context.People.Find(id);
            person.Name = name;
            int result = _context.SaveChanges();
            return person;
        }
        public void DeletePerson(Guid id)
        {
            var person = FetchPerson(id);
            _context.People.Remove(person);
            _context.SaveChanges();
        }
        #endregion

    }
}
