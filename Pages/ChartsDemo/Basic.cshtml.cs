using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PracticeSessionHashing.Pages.ChartsDemo;
public class BasicModel : PageModel
{
    public string Year { get; set; } = "Year";
    public string Sales  = "Sales";
    public void OnGet()
    {
    }
}
