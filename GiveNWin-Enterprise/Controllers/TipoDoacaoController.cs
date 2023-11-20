using GiveNWin_Enterprise.Models;
using GiveNWin_Enterprise.Peristencia;
using Microsoft.AspNetCore.Mvc;

namespace GiveNWin_Enterprise.Controllers
{
    public class TipoDoacaoController : Controller
    {
        public GiveNWinContext _context;
        public TipoDoacaoController(GiveNWinContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Excluir(int id)
        {
            var tipoDoacao = _context.TipoDoacoes.Find(id);
            _context.TipoDoacoes.Remove(tipoDoacao);
            _context.SaveChanges();
            TempData["msg"] = "Tipo de Doação removido!";

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Editar(TipoDoacao tipoDoacao)
        {
            _context.TipoDoacoes.Update(tipoDoacao);
            _context.SaveChanges();
            TempData["msg"] = "Tipo de doação atualizado com sucesso!";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {   
            var tipoDoacao = _context.TipoDoacoes.First(d => d.TipoDoacaoId == id);
            return View(tipoDoacao);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Cadastrar(TipoDoacao tipoDoacao)
        {
            _context.TipoDoacoes.Add(tipoDoacao);
            _context.SaveChanges();
            TempData["msg"] = "Tipo de doação cadastrado com sucesso!";
            return RedirectToAction("cadastrar");
        }

        public IActionResult Index(string filtro = "")
        {
            var lista = _context.TipoDoacoes
                .Where(td => td.Nome.Contains(filtro) || string.IsNullOrEmpty(filtro))
                .ToList();
            return View(lista);
        }
    }
}
