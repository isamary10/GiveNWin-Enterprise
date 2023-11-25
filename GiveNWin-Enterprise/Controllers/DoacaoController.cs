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
        public IActionResult Excluir(int id)
        {
            var doacao = _context.Doacoes
            .Include(d => d.Doador)
            .Include(d => d.DoacoesTiposDoacao)
            .FirstOrDefault(d => d.Id == id);

            if (doacao == null)
            {
                return NotFound();
            }

            // Subtrair os pontos atribuídos ao doador
            int pontuacaoRemover = _context.TipoDoacoes
                .Where(td => doacao.DoacoesTiposDoacao.Select(dtd => dtd.TipoDoacaoId).Contains(td.TipoDoacaoId))
                .Sum(td => td.Pontos);

            var doador = _context.Doadores.Find(doacao.DoadorId);
            doador.Pontuacao -= pontuacaoRemover;

            _context.Doacoes.Remove(doacao);
            _context.SaveChanges();
            TempData["msg"] = "Doação removida!";

            return RedirectToAction("Index");
        }

        public IActionResult Cadastrar()
        {
            ViewBag.Receptores = new SelectList(_context.Receptores, "ReceptorId", "RazaoSocial");
            ViewBag.Doadores = new SelectList(_context.Doadores, "DoadorId", "Nome");
            ViewBag.TipoDoacoes = new MultiSelectList(_context.TipoDoacoes, "TipoDoacaoId", "Nome");

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Doacao doacao, List<int> tipoDoacoesSelecionadas)
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

            int pontuacaoTotal = _context.TipoDoacoes
            .Where(td => tipoDoacoesSelecionadas.Contains(td.TipoDoacaoId))
            .Sum(td => td.Pontos);

            var doador = _context.Doadores.Find(doacao.DoadorId);
            doador.Pontuacao += pontuacaoTotal;

            _context.SaveChanges();

            TempData["msg"] = "Doação cadastrada com sucesso!";
            return RedirectToAction("cadastrar");
        }
        public IActionResult Index()
        {
            var lista = _context.Doacoes
                .Include(d => d.Doador)
                .Include(r => r.Receptor)
                .ToList();
            return View(lista);
        }
    }
}
