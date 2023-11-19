using GiveNWin_Enterprise.Models;
using GiveNWin_Enterprise.Peristencia;
using Microsoft.AspNetCore.Mvc;

namespace GiveNWin_Enterprise.Controllers
{
    public class CupomController : Controller
    {
        private GiveNWinContext _context;

        public CupomController(GiveNWinContext context) 
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var cupom = _context.Cupons.Find(id);
            _context.Cupons.Remove(cupom);
            _context.SaveChanges();
            TempData["msg"] = "Cupom removido!";
            
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(Cupom cupom)
        {
            _context.Cupons.Update(cupom);
            _context.SaveChanges();
            TempData["msg"] = "Cupom atualizado com sucesso!";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var cupom = _context.Cupons.First(c => c.Id == id);
            return View(cupom);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Cupom cupom)
        {
            _context.Cupons.Add(cupom);
            _context.SaveChanges();
            TempData["msg"] = "Cupom cadastrado com sucesso!";
            return RedirectToAction("cadastrar");
        }

        public IActionResult Index(string codigo = "")
        {
            var lista = _context.Cupons
                .Where(c => c.CodigoDesconto.Contains(codigo) || string.IsNullOrEmpty(codigo))
                .ToList();
            return View(lista);
        }
    }
}
