using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tarea_Razor.Pages
{
    public class Programa1Model : PageModel
    {
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";

        public double imc;

        public void OnPost()
        {

            imc = double.Parse(peso) / ((double.Parse(altura) / 100 )* (double.Parse(altura)/ 100));
            ModelState.Clear();


        }
        
    }
}
