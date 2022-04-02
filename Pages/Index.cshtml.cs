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

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            // person = new Person();
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(){
            
            if(!ModelState.IsValid){
                // return Page();
                return RedirectToPage("/Privacy");

            }
            // HttpContext.Session.SetString("Data", JsonConvert.SerializeObject(person));
                return RedirectToPage("/Privacy");
        }
    }
}
