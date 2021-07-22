using Microsoft.AspNetCore.Mvc;


namespace MVCAPP1.Controllers
{
    public class CalculosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Sumar(int primerNumero,int segundoNumero)
        {   // Todo: acceder a request.form desde asp.net core
            var primerNumeroFromBody = int.Parse(Request.Form["primerNumero"]);
            var segundoNumeroFromBody = int.Parse(Request.Form["segundoNumero"]);
            var resultadoFromBody = primerNumeroFromBody + segundoNumeroFromBody;
            var resultado = primerNumero+ segundoNumero;
            ViewData["Resultado"] = resultado;
            ViewData["ResultadoFromBody"] = resultadoFromBody;
            return View();
        }
    }
}
