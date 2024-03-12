using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCApp.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome (string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        //Get /HellowWorld
        //public string Index ()
        //{
        //    return "Esto es mi función por default";
        //}

        //Get: /HelloWorld/Welcome/
        //Requieres using Syste.Text.Encodings.Web
        //Get: /HelloWorld/Welcome?name=isidro&numtimes=5
        //public string Welcome(string name, int numTimes = 1)
        //{
        //    //return "Esta es la función de Bienvenida";
        //    return HtmlEncoder.Default.Encode($"Hello: {name}, Numtimes is: {numTimes}");
        //}

    }
}
