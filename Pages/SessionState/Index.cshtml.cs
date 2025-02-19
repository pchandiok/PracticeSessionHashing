using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeSessionHashing.Pages.SessionState;
public class IndexModel : PageModel
{
    string name;
    int age;
    public void OnGet()
    {
    }

    public void OnPost()
    {
        name = Request.Form["Name"];
        HttpContext.Session.SetString("Name", name);

        age = Convert.ToInt32(Request.Form["Age"]);
        HttpContext.Session.SetInt32("Age", age);
    }
}
