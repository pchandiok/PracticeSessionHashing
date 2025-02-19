// using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeSessionHashing.Pages.SessionState;
public class SessionModel : PageModel
{
    public string name;
    public int age;
    public void OnGet()
    {
        if( HttpContext.Session.GetString("Name") != null)
        {
            name = HttpContext.Session.GetString("Name");
        }

        if( HttpContext.Session.GetInt32("Age") != null)
        {
            age = (Int32)HttpContext.Session.GetInt32("Age");
        }
    }
}
