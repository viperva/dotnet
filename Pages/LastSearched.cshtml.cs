using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using proj.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using proj.Data;

namespace proj.Pages
{
    public class LastSearchedModel : PageModel
    {

        private readonly PeopleContext _context;

        // public People? people { get; set; }
        public IList<Person> people { get; set; }

        public LastSearchedModel(PeopleContext context){
            _context = context;
        }
        public void OnGet()
        {
            people = _context.Person.OrderByDescending(p => p.date).ThenByDescending(p => p.time).Take(20).ToList();
        }
    }
}
