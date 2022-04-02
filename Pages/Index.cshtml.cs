using proj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections;
using System.Web;
using Microsoft.AspNetCore.Session;
using System.ComponentModel.DataAnnotations;

namespace proj.Pages{

    public class IndexModel : PageModel{
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public Person person {get; set;}
        public People people = new People();
        

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
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

            var Data = HttpContext.Session.GetString("Data");
            if(Data != null){
                people = JsonConvert.DeserializeObject<People>(Data);
            }
            
            if(ModelState.IsValid){

                people.people.Add(person);

                HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(people));

            }
            
            return Page();
            
        }
    }
}
