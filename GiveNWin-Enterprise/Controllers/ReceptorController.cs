using GiveNWin_Enterprise.Models;
using GiveNWin_Enterprise.Peristencia;
using Microsoft.AspNetCore.Mvc;

namespace GiveNWin_Enterprise.Controllers
{
    public class ReceptorController : Controller
    {
        public GiveNWinContext _context;
        public ReceptorController(GiveNWinContext context) 
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var receptor = _context.Receptores.Find(id);
            _context.Receptores.Remove(receptor);
            _context.SaveChanges();
            TempData["msg"] = "Receptor removido!";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Receptor receptor)
        {
            _context.Receptores.Update(receptor);
            _context.SaveChanges();
            TempData["msg"] = "Receptor atualizado com sucesso!";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var receptor = _context.Receptores.First(d => d.Id == id);
            return View(receptor);
        }
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Receptor receptor)
        {
            _context.Receptores.Add(receptor);
            _context.SaveChanges();
            TempData["msg"] = "Receptor cadastrado com sucesso!";
            return RedirectToAction("cadastrar");
        }
        public IActionResult Index(string filtro = "")
        {
            var lista = _context.Receptores
                .Where(r => r.Cnpj.Contains(filtro) || string.IsNullOrEmpty(filtro))
                .ToList();
            return View(lista);
        }
    }
}
