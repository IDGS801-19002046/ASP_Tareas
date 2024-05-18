using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;

namespace Tarea_Razor.Pages
{
    public class Programa3Model : PageModel
    {
        [BindProperty]
        public int a { get; set; } = 0;
        [BindProperty]
        public int b { get; set; } = 0;
        [BindProperty]
        public int x { get; set; } = 0;
        [BindProperty]
        public int y { get; set; } = 0;
        [BindProperty]
        public int n { get; set; } = 0;

        public double f1 = 0;
     

        public void OnPost()
        {
            f1 = Math.Pow(((a * x) + (b * y)), n);


        }
    }




}

