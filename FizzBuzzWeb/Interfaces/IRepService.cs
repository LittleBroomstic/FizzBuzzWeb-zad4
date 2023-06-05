using FizzBuzzWeb.Models;
using Microsoft.EntityFrameworkCore;
using FizzBuzzWeb.Services;

namespace FizzBuzzWeb.Interfaces
{
    public interface IRepService
    {
        public void AddPersonR(Person person);
        public IQueryable<Person> GetPerson();
    }
}
