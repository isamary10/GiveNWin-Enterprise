using GiveNWin_Enterprise.Models;
using GiveNWin_Enterprise.Peristencia;
using Microsoft.AspNetCore.Mvc;

namespace GiveNWin_Enterprise.Controllers
{
    public class ParceiroController : Controller
    {
        public GiveNWinContext _context;
        public ParceiroController(GiveNWinContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var parceiro = _context.Parceiros.Find(id);
            _context.Parceiros.Remove(parceiro);
            _context.SaveChanges();
            TempData["msg"] = "Parceiro removido!";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Parceiro parceiro)
        {
            _context.Parceiros.Update(parceiro);
            _context.SaveChanges();
            TempData["msg"] = "Parceiro atualizado com sucesso!";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var parceiro = _context.Parceiros.First(d => d.Id == id);
            return View(parceiro);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Parceiro parceiro)
        {
            _context.Parceiros.Add(parceiro);
            _context.SaveChanges();
            TempData["msg"] = "Parceiro cadastrado com sucesso!";
            return RedirectToAction("cadastrar");
        }

        public IActionResult Index(string filtro = "")
        {
            var lista = _context.Parceiros
                .Where(p => p.Cnpj.Contains(filtro) || string.IsNullOrEmpty(filtro))
                .ToList();
            return View(lista);
        }
    }
}
