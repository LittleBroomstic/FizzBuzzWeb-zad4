//using EFDemo.Models;
using Microsoft.EntityFrameworkCore;
using FizzBuzzWeb.Models;
namespace FizzBuzzWeb.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> Person { get; set; }
    }
}
