using FizzBuzzWeb.Models;
using FizzBuzzWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ContosoUniversity;
using Microsoft.EntityFrameworkCore;
using FizzBuzzWeb.Interfaces;
using FizzBuzzWeb.Services;
using System.Linq;

namespace FizzBuzzWeb.Pages
{
    public class SearchHistoryModel : PageModel
    {
        //private readonly PeopleContext _context;
        //public List<FizzBuzzForm> FizzBuzzList = new List<FizzBuzzForm>();

        private readonly IPersonService _personService;

        IQueryable<Person> query;

        private readonly ILogger<SearchHistoryModel> _logger;
        [BindProperty]
        public Person Person { get; set; }
        public PaginatedList<Person> PeoplePage { get; set; }

        public IList<Person> PeopleList { get; set; }
        public SearchHistoryModel(ILogger<SearchHistoryModel> logger, IPersonService personService)
        {
            _logger = logger;
            _personService = personService;
            //_context = context;
        }
        public void OnGet(int pageIndex = 1)
        {
            PeopleList = _personService.GetList();
            query = PeopleList.AsQueryable();
            query = query.OrderByDescending(s => s.date);
            //PeoplePage = PaginatedList<Person>.CreateAsync(PeoplePage.OrderByDescending(s => s.date), pageIndex, 20);
            //PeoplePage = PaginatedList<Person>.CreateAsync(_context.Person.AsQueryable().OrderByDescending(s => s.date), pageIndex, 20);
            PeoplePage = PaginatedList<Person>.CreateAsync(query, pageIndex, 20);
        }
    }
}
