using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnsinoMedio.Controllers
{
    public class ProfessorController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Cadastro()
        {
            return View();
        }
        public ActionResult Welcome() 
        {
            return View();
        }

        // GET: HomeController/Create
    }
}