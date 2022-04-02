using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using proj.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace proj.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public Person person { get; set; }
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");

            if(Data != null) person = JsonConvert.DeserializeObject<Person>(Data);
        }
    }
}
