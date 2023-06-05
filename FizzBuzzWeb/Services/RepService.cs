using FizzBuzzWeb.Data;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.Pages;
using FizzBuzzWeb.Interfaces;

namespace FizzBuzzWeb.Services
{
    public class RepService : IRepService
    {
        private readonly PeopleContext _context;
        public RepService(PeopleContext context)
        {
            _context = context;
        }
        public IQueryable<Person> GetPerson()
        {
            return _context.Person;
        }
        public void AddPersonR(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
        }
    }
}
