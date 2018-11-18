using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ArticoliGratis.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ArticoliGratis.Controllers
{



    public class HomeController : Controller
    {

        private readonly ArticoliGratisContext _context;

        public HomeController(ArticoliGratisContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult CategorieArticoli(int idCat)
        {
            ViewData["Message"] = "Your contact page.";
            ViewBag.Titolo = "Titolo Articoli Categoria";

            /* 
            Utente utente =new Utente();
            utente.Nome = "Aniello";
            utente.Cognome = "Amato" ;         
            Articolo articolo = new Articolo();
            articolo.titolo = "Titolo" ;
            articolo.testo= "Testo";
            articolo.autore= utente;
            _context.Articoli.Add(articolo);
            _context.SaveChanges();
            */

            List<Articolo> articoli = _context.Articoli
            .Include(x => x.autore)
            .ToList();
            /* 
             Articolo articolo2 = _context        
             .Articoli.Where(x => x.idArticolo ==1)
             .Include(x => x.autore)
             .FirstOrDefault();
             */


            return View(articoli);
        }
        [HttpGet]
        public IActionResult Iscriviti()
        {

            @ViewBag.Sessi = _context.Sessi.ToList();
            @ViewBag.Lavori = _context.Lavori.ToList();
            @ViewBag.TitoliDiStudio = _context.TitoliDiStudio.ToList();
            @ViewBag.Settori = _context.Settori.ToList();
            @ViewBag.CategorieAzienda = _context.CategorieAziende.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Iscriviti(Utente utente)
        {
            IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(v => v.Errors);

            ModelState.Remove("DatiAnagraficiUtnte.sesso.NomeSesso");
            ModelState.Remove("DatiAnagraficiUtnte.settore.NomeSettore");
            ModelState.Remove("DatiAnagraficiUtnte.titolodiStudio.NomeTitolodiStudio");
            ModelState.Remove("DatiAnagraficiUtnte.lavoro.NomeLavoro");
            ModelState.Remove("DatiAziendali.categoriaAzienda.NomeCategoria");

            if (ModelState.IsValid)
            {
                utente.DatiAnagraficiUtnte.sesso = _context.Sessi.Where(x => x.idSesso == utente.DatiAnagraficiUtnte.sesso.idSesso).FirstOrDefault();
                utente.DatiAnagraficiUtnte.settore = _context.Settori.Where(x => x.idSettore == utente.DatiAnagraficiUtnte.settore.idSettore).FirstOrDefault();
                utente.DatiAnagraficiUtnte.titolodiStudio = _context.TitoliDiStudio.Where(x => x.idTitoloDiStudio == utente.DatiAnagraficiUtnte.titolodiStudio.idTitoloDiStudio).FirstOrDefault();
                utente.DatiAnagraficiUtnte.lavoro = _context.Lavori.Where(x => x.idLavoro == utente.DatiAnagraficiUtnte.lavoro.idLavoro).FirstOrDefault();
                utente.DatiAziendali.CategoriaAzienda = _context.CategorieAziende.Where(x => x.idCategoriaAzienda == utente.DatiAziendali.CategoriaAzienda.idCategoriaAzienda).FirstOrDefault();

                _context.Utenti.Add(utente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                @ViewBag.Sessi = _context.Sessi.ToList();
                @ViewBag.Lavori = _context.Lavori.ToList();
                @ViewBag.TitoliDiStudio = _context.TitoliDiStudio.ToList();
                @ViewBag.Settori = _context.Settori.ToList();
                @ViewBag.CategorieAzienda = _context.CategorieAziende.ToList();
                return View(utente);
            }

        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
