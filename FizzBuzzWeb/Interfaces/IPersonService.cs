using ContosoUniversity;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.ViewModels;

namespace FizzBuzzWeb.Interfaces
{
    public interface IPersonService
    {
        //public IQueryable<Person> GetActivePeople();
        public void AddPerson(Person person);
        public PaginatedList<PersonVM> getPList(int pageIndex);
    }
}
