using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using proj.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace proj.Pages
{
    public class SavedInSessionModel : PageModel
    {
        public People people { get; set; }
        public void OnGet()
        {
            var Data = HttpContext.Session.GetString("Data");

            if(Data != null) people = JsonConvert.DeserializeObject<People>(Data);

            HttpContext.Session.SetString("Data2", JsonConvert.SerializeObject(people));

        }
    }
}
