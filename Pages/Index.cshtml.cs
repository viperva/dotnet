using proj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections;
using System.Web;
using Microsoft.AspNetCore.Session;
using System.ComponentModel.DataAnnotations;
using proj.Data;

namespace proj.Pages{

    public class IndexModel : PageModel{
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _context;
 
        [BindProperty]
        public Person person {get; set;}
        public People people = new People();
        

        public IndexModel(ILogger<IndexModel> logger, PeopleContext context)
        {

            _logger = logger;
            _context = context;
            person = new Person();
        }

        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");
            if(Data != null){
                people = JsonConvert.DeserializeObject<People>(Data);
            }
        }
        public IActionResult OnPost(){

            // DateTime date = DateTime.UtcNow.Date;
            // TimeSpan time = 

            person.date = DateTime.Now.Date;
            person.time = DateTime.Now.TimeOfDay;

            var Data = HttpContext.Session.GetString("Data");
            if(Data != null){
                people = JsonConvert.DeserializeObject<People>(Data);
            }
            
            if(ModelState.IsValid){

                people.people.Add(person);

                HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(people));

                _context.Person.Add(person);
                _context.SaveChanges();
                return Page();
            }
            
            return Page();
            
        }
    }
}
