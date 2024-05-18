using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tarea_Razor.Pages
{
    public class Programa2Model : PageModel
    {
        [BindProperty]
        public string Mensaje { get; set; }

        [BindProperty]
        public int Desplazamiento { get; set; }

        [BindProperty]
        public string Codificar { get; set; }

        [BindProperty]
        public string Decodificar { get; set; }

        public void OnPostEncode()
        {
            Codificar = Cifrado(Mensaje.ToUpper(), Desplazamiento);
        }

        public void OnPostDecode()
        {
            Decodificar = Cifrado(Mensaje.ToUpper(), -Desplazamiento);
        }

        private string Cifrado(string texto, int Desplazamiento)
        {
            const string letra = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string resultado = "";
            Desplazamiento = Desplazamiento % 26;

            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];
                if (letra.Contains(c))
                {
                    int oldIndex = letra.IndexOf(c);
                    int newIndex = (oldIndex + Desplazamiento + 26) % 26;
                    resultado += letra[newIndex];
                }
                else
                {
                    resultado += c;
                }
            }

            return resultado;
        }

    }
}
