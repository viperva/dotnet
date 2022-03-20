using proj.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace proj.Pages{

    public class IndexModel : PageModel{
        private readonly ILogger<IndexModel> _logger;

        [BindProperty]
        public FizzBuzz Fizzbuzz {get; set;}

        [BindProperty(SupportsGet = true)]
        public string? Name {get; set;}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Fizzbuzz = new FizzBuzz();
        }

        public void OnGet()
        {
            if(string.IsNullOrEmpty(Name)){
                Name = "User";
            }
        }
        // public IActionResult OnPost(){
        //     if (!ModelState.IsValid){
        //         return Page();
        //     }
        //     return RedirectToPage("./Privacy");
        // }
    }
}
