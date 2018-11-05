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
    public class AdministrationController  : Controller
    {

    private readonly ArticoliGratisContext _context;

    public AdministrationController(ArticoliGratisContext context)
    {
        _context = context;
    }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LavoriUtenti()
        {
            List<Lavoro> LavoriUtenti = _context.Lavori.ToList();
            return View(LavoriUtenti);
        }

         [HttpGet]
         public IActionResult Create_LavoriUtenti()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create_LavoriUtenti(Lavoro lavoro)
        {
            if (ModelState.IsValid)
            {
                _context.Lavori.Add(lavoro); 
                _context.SaveChanges();
               return RedirectToAction("LavoriUtenti");
            }
            else
            {
              return View(lavoro);
            }
        }
        [HttpGet]
         public IActionResult Edit_LavoriUtenti(int id)
        {
            Lavoro lavoro = _context.Lavori.Where(x => x.idLavoro ==id).FirstOrDefault();
            return View(lavoro );
        }

        [HttpPost]
        public IActionResult Edit_LavoriUtenti(Lavoro lavoro)
        {
            if (ModelState.IsValid)
            {
                _context.Lavori.Update(lavoro); 
                _context.SaveChanges();
               return RedirectToAction("LavoriUtenti");
            }
            else
            {
              return View(lavoro);
            }
        }

         [HttpGet]
         public IActionResult Delete_LavoriUtenti(int id)
        {
            Lavoro lavoro = _context.Lavori.Where(x => x.idLavoro ==id).FirstOrDefault();
            return View(lavoro);
        }

        [HttpPost]
        public IActionResult Delete_LavoriUtenti(Lavoro lavoro)
        {
             if(lavoro != null)
             {
                 return View("ConfirmDelete_LavoriUtente", lavoro);
             }
             return View("LavoriUtente");
            
        }

        [HttpPost]
        public IActionResult ConfirmDelete_LavoriUtenti(Lavoro lavoro)
        {
             if(lavoro != null)
             {
               _context.Lavori.Remove(lavoro);
               _context.SaveChanges();
               return RedirectToAction("LavoriUtenti");
             }
             return View("LavoriUtente");
            
        }




    }
}