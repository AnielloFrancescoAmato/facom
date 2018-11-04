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


    }
}