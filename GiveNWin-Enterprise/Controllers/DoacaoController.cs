using GiveNWin_Enterprise.Models;
using GiveNWin_Enterprise.Peristencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace GiveNWin_Enterprise.Controllers
{
    public class DoacaoController : Controller
    {
        public GiveNWinContext _context { get; set; }
        public DoacaoController(GiveNWinContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Editar(Doacao doacao)
        {
            _context.Doacoes.Update(doacao);
            _context.SaveChanges();
            TempData["msg"] = "Doação atualizado com sucesso!";
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var doacao = _context.Doacoes.First(d => d.Id == id);
            return View(doacao);
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Receptores = new SelectList(_context.Receptores, "ReceptorId", "RazaoSocial");
            ViewBag.Doadores = new SelectList(_context.Doadores, "DoadorId", "Nome");
            ViewBag.TipoDoacoes = new MultiSelectList(_context.TipoDoacoes, "TipoDoacaoId", "Nome");

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Doacao doacao, List<int> tipoDoacoesSelecionadas, Doador doador)
        {
            _context.Doacoes.Add(doacao);
            _context.SaveChanges();

            // Adiciona os tipos de doação selecionados
            foreach (var tipoDoacaoId in tipoDoacoesSelecionadas)
            {
                var doacaoTipoDoacao = new DoacaoTipoDoacao
                {
                    DoacaoId = doacao.Id,
                    TipoDoacaoId = tipoDoacaoId
                };
               
                _context.DoacoesTiposDoacao.Add(doacaoTipoDoacao);
            }

            _context.SaveChanges();

            TempData["msg"] = "Doação cadastrada com sucesso!";
            return RedirectToAction("cadastrar");
        }
        public IActionResult Index()
        {
            var lista = _context.Doacoes
                .ToList();
            return View(lista);
        }
    }
}
