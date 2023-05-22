using FizzBuzzWeb.Data;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Services
{
    public class PersonService : IPersonService
    {
        private readonly PeopleContext _context;
        public PersonService(PeopleContext context)
        {
            _context = context;
        }
        public void AddPerson(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
        }
        public List<Person> GetList()
        {
            return _context.Person.ToList();
        }
        //public IQueryable<Person> GetActivePeople()
        //{
        //    return
        //    _context.Person.Where(p => p.IsActive);
        //}
    }
}
