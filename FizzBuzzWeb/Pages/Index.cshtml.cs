using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FizzBuzzWeb.Forms;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using FizzBuzzWeb.Models;
using FizzBuzzWeb.Data;
using System.Security.Claims;

namespace FizzBuzzWeb.Pages
{
public class IndexModel : PageModel
{
    private readonly PeopleContext _context;
    //public List<FizzBuzzForm> FizzBuzzList = new List<FizzBuzzForm>();
    private readonly ILogger<IndexModel> _logger;

    [BindProperty]
    public Person Person { get; set; }
    //public FizzBuzzForm FizzBuzz { set; get; }

    public int flag = 0;

    public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
    {
            _logger = logger;
            _context = context;
    }
    public IList<Person> PeopleList { get; set; }
    public void OnGet()
    {
        //PeopleList = _context.Person.ToList();
    }
    public IActionResult OnPost()
    {
            
            PeopleList = _context.Person.ToList();
            Person.date = DateTime.Now;
            Person.userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            flag = 1;
            /*
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            

            //return RedirectToPage("./Index");

            var Data = HttpContext.Session.GetString("sessionList");

            if (Data != null)
            {
                PeopleList = JsonConvert.DeserializeObject<List<FizzBuzzForm>>(Data).ToList();
            }
            */

            if (Person.Number % 4 == 0)
            {
                Person.result = "Leap year";
            }
            else
            {
                 Person .result = "Normal year";
            }
            
            //HttpContext.Session.SetString("sessionList", JsonConvert.SerializeObject(PeopleList));
            _context.Person.Add(Person);
            _context.SaveChanges();
            return Page();
    }
}
}

