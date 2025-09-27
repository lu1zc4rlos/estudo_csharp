using Microsoft.AspNetCore.Mvc;

namespace Asp.NET_MVC.Controllers {
    public class ContatoController : Controller {
        [HttpGet("{id?}")]
        public IActionResult Listar(int id = 1) 
        {
            return View(id);
        }
        [HttpPost]
        public IActionResult Adicionar([FromBody] String contato) 
        {
            return View("Listar", contato);
        }

        [HttpPost]
        public IActionResult Festa([FromBody] String festa) {
            return View(Festa);
        }

    }
}
