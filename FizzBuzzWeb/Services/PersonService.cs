using ContosoUniversity;
using FizzBuzzWeb.Data;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.ViewModels;
using Microsoft.VisualBasic;

namespace FizzBuzzWeb.Services
{
    public class PersonService : IPersonService
    {
        

        private readonly IRepService _repService;
        public PersonService(RepService context)
        {
            _repService = context;
        }
        public PaginatedList<PersonVM> getPList(int pageIndex)
        {
            var query = _repService.GetPerson();

            List<PersonVM> PeopleList = new List<PersonVM>();

            foreach(var item in query)
            {
                var Data = new PersonVM
                {
                    Id = item.Id,
                    userID = item.userID,
                    Name = item.username,
                    Year = item.Number,

                };
                PeopleList.Add(Data);
            }
            return PaginatedList<PersonVM>.Create(PeopleList, pageIndex, 20);
        }
        public void AddPerson(Person person)
        {
            _repService.AddPersonR(person);
        }
    }
}
