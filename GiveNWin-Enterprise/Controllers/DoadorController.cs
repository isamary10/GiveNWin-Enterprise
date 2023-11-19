using GiveNWin_Enterprise.Models;
using GiveNWin_Enterprise.Peristencia;
using Microsoft.AspNetCore.Mvc;

namespace GiveNWin_Enterprise.Controllers
{
    public class DoadorController : Controller
    {
        public GiveNWinContext _context;
        public DoadorController(GiveNWinContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var doador = _context.Doadores.Find(id);
            _context.Doadores.Remove(doador);
            _context.SaveChanges();
            TempData["msg"] = "Doador removido!";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Doador doador)
        {
            _context.Doadores.Update(doador);
            _context.SaveChanges();
            TempData["msg"] = "Doador atualizado com sucesso!";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var doador = _context.Doadores.First(d => d.Id == id);
            return View(doador);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(Doador doador)
        {
            _context.Doadores.Add(doador);
            _context.SaveChanges();
            TempData["msg"] = "Doador cadastrado com sucesso!";
            return RedirectToAction("cadastrar");
        }

        public IActionResult Index(string cpf = "")
        {
            var lista = _context.Doadores
                .Where(c => c.Cpf.Contains(cpf) || string.IsNullOrEmpty(cpf))
                .ToList();
            return View(lista);
        }

    }
}
