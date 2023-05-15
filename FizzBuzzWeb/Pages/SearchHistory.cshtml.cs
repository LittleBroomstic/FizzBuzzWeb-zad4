using FizzBuzzWeb.Models;
using FizzBuzzWeb.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using ContosoUniversity;
using Microsoft.EntityFrameworkCore;

namespace FizzBuzzWeb.Pages
{
    public class SearchHistoryModel : PageModel
    {
        private readonly PeopleContext _context;
        //public List<FizzBuzzForm> FizzBuzzList = new List<FizzBuzzForm>();
        private readonly ILogger<SearchHistoryModel> _logger;
        [BindProperty]
        public Person Person { get; set; }
        public PaginatedList<Person> PeoplePage { get; set; }
        //public IList<Person> PeopleList { get; set; }
        public SearchHistoryModel(ILogger<SearchHistoryModel> logger, PeopleContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public void OnGet(int pageIndex = 1)
        {
            IQueryable<Person> query = _context.Person.AsQueryable();
            query = query.OrderByDescending(s => s.date);
            //PeoplePage = PaginatedList<Person>.CreateAsync(PeoplePage.OrderByDescending(s => s.date), pageIndex, 20);
            //PeoplePage = PaginatedList<Person>.CreateAsync(_context.Person.AsQueryable().OrderByDescending(s => s.date), pageIndex, 20);
            PeoplePage = PaginatedList<Person>.CreateAsync(query, pageIndex, 20);
        }
    }
}
