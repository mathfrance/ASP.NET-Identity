using ByteBank.Forum.ViewModels;
using System.Web.Mvc;

namespace ByteBank.Forum.Controllers
{
    [Authorize]
    public class TopicoController : Controller
    {
        [HttpGet]
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(TopicoCriarViewModel modelo)
        {
            return View();
        }
    }
}