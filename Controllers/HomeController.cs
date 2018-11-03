using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using ArticoliGratis.Models;


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



        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
