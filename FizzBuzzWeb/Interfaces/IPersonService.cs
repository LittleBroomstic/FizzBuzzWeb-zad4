using FizzBuzzWeb.Models;

namespace FizzBuzzWeb.Interfaces
{
    public interface IPersonService
    {
        //public IQueryable<Person> GetActivePeople();
        public void AddPerson(Person person);
        public List<Person> GetList();
    }
}
