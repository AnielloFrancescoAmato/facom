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
    public class AdministrationController : Controller
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

        public IActionResult TitolidiStudio()
        {
            List<TitoloDiStudio> titolidiStudio = _context.TitoliDiStudio.ToList();
            return View(titolidiStudio);
        }


        [HttpGet]
        public IActionResult TitolidiStudio_Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TitolidiStudio_Create(TitoloDiStudio titoloStudio)
        {
            if (ModelState.IsValid)
            {
                _context.TitoliDiStudio.Add(titoloStudio);
                _context.SaveChanges();
                return RedirectToAction("TitolidiStudio");
            }
            else
            {
                return View(titoloStudio);
            }
        }
        [HttpGet]
        public IActionResult TitolidiStudio_Edit(int id)
        {
            TitoloDiStudio titoloStudio = _context.TitoliDiStudio.Where(x => x.idTitoloDiStudio == id).FirstOrDefault();
            return View(titoloStudio);
        }

        [HttpPost]
        public IActionResult TitolidiStudio_Edit(TitoloDiStudio titoloStudio)
        {
            if (ModelState.IsValid)
            {
                _context.TitoliDiStudio.Update(titoloStudio);
                _context.SaveChanges();
                return RedirectToAction("TitolidiStudio");
            }
            else
            {
                return View(titoloStudio);
            }
        }


        [HttpGet]
        public IActionResult TitolidiStudio_Delete(int id)
        {
            TitoloDiStudio titoloStudio = _context.TitoliDiStudio.Where(x => x.idTitoloDiStudio == id).FirstOrDefault();
            return View(titoloStudio);
        }

        [HttpPost]
        public IActionResult TitolidiStudio_Delete(TitoloDiStudio titoloStudio)
        {
            if (titoloStudio != null)
            {
                return View("ConfirmDelete_TitolidiStudio", titoloStudio);
            }
            return View("TitolidiStudio");

        }

        [HttpPost]
        public IActionResult TitolidiStudio_ConfirmDelete(TitoloDiStudio titoloStudio)
        {
            if (titoloStudio != null)
            {
                _context.TitoliDiStudio.Remove(titoloStudio);
                _context.SaveChanges();
                return RedirectToAction("TitolidiStudio");
            }
            return View("TitolidiStudio");

        }



        public IActionResult Sesso()
        {
            List<Sesso> sessi = _context.Sessi.ToList();
            return View(sessi);
        }


        [HttpGet]
        public IActionResult Sesso_Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sesso_Create(Sesso sesso)
        {
            if (ModelState.IsValid)
            {
                _context.Sessi.Add(sesso);
                _context.SaveChanges();
                return RedirectToAction("Sesso");
            }
            else
            {
                return View(sesso);
            }
        }
        [HttpGet]
        public IActionResult Sesso_Edit(int id)
        {
            Sesso sesso = _context.Sessi.Where(x => x.idSesso == id).FirstOrDefault();
            return View(sesso);
        }

        [HttpPost]
        public IActionResult Sesso_Edit(Sesso sesso)
        {
            if (ModelState.IsValid)
            {
                _context.Sessi.Update(sesso);
                _context.SaveChanges();
                return RedirectToAction("Sesso");
            }
            else
            {
                return View(sesso);
            }
        }


        [HttpGet]
        public IActionResult Sesso_Delete(int id)
        {
            Sesso sesso = _context.Sessi.Where(x => x.idSesso == id).FirstOrDefault();
            return View(sesso);
        }

        [HttpPost]
        public IActionResult Sesso_Delete(Sesso sesso)
        {
            if (sesso != null)
            {
                return View("ConfirmDelete_Sesso", sesso);
            }
            return View("Sesso");

        }

        [HttpPost]
        public IActionResult Sesso_ConfirmDelete(Sesso sesso)
        {
            if (sesso != null)
            {
                _context.Sessi.Remove(sesso);
                _context.SaveChanges();
                return RedirectToAction("Sesso");
            }
            return View("Sesso");

        }







        public IActionResult Regione()
        {
            List<Regione> regioni = _context.Regioni.ToList();
            return View(regioni);
        }


        [HttpGet]
        public IActionResult Regione_Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Regione_Create(Regione regione)
        {
            if (ModelState.IsValid)
            {
                _context.Regioni.Add(regione);
                _context.SaveChanges();
                return RedirectToAction("Regione");
            }
            else
            {
                return View(regione);
            }
        }
        [HttpGet]
        public IActionResult Regione_Edit(int id)
        {
            Regione regione = _context.Regioni.Where(x => x.idRegione == id).FirstOrDefault();
            return View(regione);
        }

        [HttpPost]
        public IActionResult Regione_Edit(Regione regione)
        {
            if (ModelState.IsValid)
            {
                _context.Regioni.Update(regione);
                _context.SaveChanges();
                return RedirectToAction("Regione");
            }
            else
            {
                return View(regione);
            }
        }


        [HttpGet]
        public IActionResult Regione_Delete(int id)
        {
            Regione regione = _context.Regioni.Where(x => x.idRegione== id).FirstOrDefault();
            return View(regione);
        }

        [HttpPost]
        public IActionResult Regione_Delete(Regione regione)
        {
            if (regione != null)
            {
                return View("ConfirmDelete_Regione", regione);
            }
            return View("Regione");

        }

        [HttpPost]
        public IActionResult Regione_ConfirmDelete(Regione regione)
        {
            if (regione != null)
            {
                _context.Regioni.Remove(regione);
                _context.SaveChanges();
                return RedirectToAction("Regione");
            }
            return View("Regione");

        }



        public IActionResult Provincia()
        {
            List<Provincia> province = _context.Province
            .Include(x =>x.Regione)
            .ToList();
            return View(province);
        }


        [HttpGet]
        public IActionResult Provincia_Create()
        {
            @ViewBag.regioni = _context.Regioni.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Provincia_Create(Provincia provincia)
        {
            ModelState.Remove("Regione.NomeRegione");
            if (ModelState.IsValid)
            {
                provincia.Regione = _context.Regioni.Where(x => x.idRegione ==provincia.Regione.idRegione).FirstOrDefault();
                _context.Province.Add(provincia);
                _context.SaveChanges();
                return RedirectToAction("Provincia");
            }
            else
            {
                @ViewBag.regioni = _context.Regioni.ToList();
                return View(provincia);
            }
        }
        [HttpGet]
        public IActionResult Provincia_Edit(int id)
        {
            Provincia provincia = _context.Province.Where(x => x.idProvincia == id).FirstOrDefault();
            @ViewBag.regioni = _context.Regioni.ToList();
            return View( provincia );
        }

        [HttpPost]
        public IActionResult  Provincia_Edit( Provincia  provincia)
        {
            ModelState.Remove("Regione.NomeRegione");
            if (ModelState.IsValid)
            {
                 provincia.Regione = _context.Regioni.Where(x => x.idRegione ==provincia.Regione.idRegione).FirstOrDefault();
                _context.Province.Update(provincia);
                _context.SaveChanges();
                return RedirectToAction("Provincia");
            }
            else
            {
                @ViewBag.regioni = _context.Regioni.ToList();
                return View(provincia);
            }
        }


        [HttpGet]
        public IActionResult Provincia_Delete(int id)
        {
            Provincia provincia = _context.Province.Where(x => x.idProvincia== id).FirstOrDefault();
            @ViewBag.regioni = _context.Regioni.ToList();
            return View(provincia);
        }

        [HttpPost]
        public IActionResult Provincia_Delete(Provincia provincia)
        {
            if (provincia != null)
            {
                return View("ConfirmDelete_Provincia", provincia);
            }
            return View("Provincia");

        }

        [HttpPost]
        public IActionResult Provincia_ConfirmDelete(Provincia provincia)
        {
            if (provincia != null)
            {
                _context.Province.Remove(provincia);
                _context.SaveChanges();
                return RedirectToAction("Provincia");
            }
            return View("Provincia");

        }







        public IActionResult Comune()
        {
            List<Comune> comuni = _context.Comuni
            .Include(x =>x.Provincia)
            .ToList();
            return View(comuni);
        }


        [HttpGet]
        public IActionResult Comune_Create()
        {
            @ViewBag.province = _context.Province.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Comune_Create(Comune comune)
        {
            ModelState.Remove("Provincia.NomeProvincia");
            if (ModelState.IsValid)
            {
                comune.Provincia = _context.Province.Where(x => x.idProvincia ==comune.Provincia.idProvincia).FirstOrDefault();
                _context.Comuni.Add(comune);
                _context.SaveChanges();
                return RedirectToAction("Comune");
            }
            else
            {
                @ViewBag.province = _context.Province.ToList();
                return View(comune);
            }
        }
        [HttpGet]
        public IActionResult Comune_Edit(int id)
        {
            Comune comune = _context.Comuni.Where(x => x.idComune == id).FirstOrDefault();
             @ViewBag.province = _context.Province.ToList();
            return View( comune );
        }

        [HttpPost]
        public IActionResult  Comune_Edit( Comune  comune)
        {
            ModelState.Remove("Provincia.NomeProvincia");
            if (ModelState.IsValid)
            {
                 comune.Provincia = _context.Province.Where(x => x.idProvincia ==comune.Provincia.idProvincia).FirstOrDefault();
                _context.Comuni.Update(comune);
                _context.SaveChanges();
                return RedirectToAction("Comune");
            }
            else
            {
                @ViewBag.province = _context.Province.ToList();
                return View(comune);
            }
        }


        [HttpGet]
        public IActionResult Comune_Delete(int id)
        {
            Comune comune = _context.Comuni.Where(x => x.idComune== id).FirstOrDefault();
            @ViewBag.province = _context.Province.ToList();
            return View(comune);
        }

        [HttpPost]
        public IActionResult Comune_Delete(Comune comune)
        {
            if (comune != null)
            {
                return View("ConfirmDelete_Comune", comune);
            }
            return View("Comune");

        }

        [HttpPost]
        public IActionResult Comune_ConfirmDelete(Comune comune)
        {
            if (comune != null)
            {
                _context.Comuni.Remove(comune);
                _context.SaveChanges();
                return RedirectToAction("Comune");
            }
            return View("Comune");

        }







        public IActionResult CategoriaAzienda()
        {
            List<CategoriaAzienda> categorieAzienda = _context.CategorieAziende.ToList();
            return View(categorieAzienda);
        }


        [HttpGet]
        public IActionResult CategoriaAzienda_Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoriaAzienda_Create(CategoriaAzienda categoriaAzienda)
        {
            if (ModelState.IsValid)
            {
                _context.CategorieAziende.Add(categoriaAzienda);
                _context.SaveChanges();
                return RedirectToAction("CategoriaAzienda");
            }
            else
            {
                return View(categoriaAzienda);
            }
        }
        [HttpGet]
        public IActionResult CategoriaAzienda_Edit(int id)
        {
            CategoriaAzienda  categoriaAzienda  = _context.CategorieAziende.Where(x => x.idCategoriaAzienda == id).FirstOrDefault();
            return View(categoriaAzienda);
        }

        [HttpPost]
        public IActionResult CategoriaAzienda_Edit(CategoriaAzienda categorieAzienda)
        {
            if (ModelState.IsValid)
            {
                _context.CategorieAziende.Update(categorieAzienda);
                _context.SaveChanges();
                return RedirectToAction("CategoriaAzienda");
            }
            else
            {
                return View(categorieAzienda);
            }
        }


        [HttpGet]
        public IActionResult CategoriaAzienda_Delete(int id)
        {
            CategoriaAzienda categoriaAzienda = _context.CategorieAziende.Where(x => x.idCategoriaAzienda== id).FirstOrDefault();
            return View(categoriaAzienda );
        }

        [HttpPost]
        public IActionResult CategoriaAzienda_Delete(CategoriaAzienda categoriaAzienda)
        {
            if (categoriaAzienda != null)
            {
                return View("ConfirmDelete_CategoriaAzienda", categoriaAzienda );
            }
            return View("CategoriaAzienda");

        }

        [HttpPost]
        public IActionResult CategoriaAzienda_ConfirmDelete(CategoriaAzienda categoriaAzienda)
        {
            if (categoriaAzienda!= null)
            {
                _context.CategorieAziende.Remove(categoriaAzienda);
                _context.SaveChanges();
                return RedirectToAction("CategoriaAzienda");
            }
            return View("CategoriaAzienda");

        }








        public IActionResult Settore()
        {
            List<Settore> settori = _context.Settori.ToList();
            return View(settori);
        }


        [HttpGet]
        public IActionResult Settore_Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Settore_Create(Settore settore)
        {
            if (ModelState.IsValid)
            {
                _context.Settori.Add(settore);
                _context.SaveChanges();
                return RedirectToAction("Settore");
            }
            else
            {
                return View(settore);
            }
        }
        [HttpGet]
        public IActionResult Settore_Edit(int id)
        {
            Settore settore = _context.Settori.Where(x => x.idSettore == id).FirstOrDefault();
            return View(settore);
        }

        [HttpPost]
        public IActionResult Settore_Edit(Settore settore)
        {
            if (ModelState.IsValid)
            {
                _context.Settori.Update(settore);
                _context.SaveChanges();
                return RedirectToAction("Settore");
            }
            else
            {
                return View(settore);
            }
        }


        [HttpGet]
        public IActionResult Settore_Delete(int id)
        {
            Settore settore = _context.Settori.Where(x => x.idSettore == id).FirstOrDefault();
            return View(settore);
        }

        [HttpPost]
        public IActionResult Settore_Delete(Settore settore)
        {
            if (settore != null)
            {
                return View("ConfirmDelete_Settore", settore);
            }
            return View("Settore");

        }

        [HttpPost]
        public IActionResult Settore_ConfirmDelete(Settore settore)
        {
            if (settore != null)
            {
                _context.Settori.Remove(settore);
                _context.SaveChanges();
                return RedirectToAction("Settore");
            }
            return View("Settore");

        }



        public IActionResult LavoriUtenti()
        {
            List<Lavoro> LavoriUtenti = _context.Lavori.ToList();
            return View(LavoriUtenti);
        }

        [HttpGet]
        public IActionResult LavoriUtenti_Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LavoriUtenti_Create(Lavoro lavoro)
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
        public IActionResult LavoriUtenti_Edit(int id)
        {
            Lavoro lavoro = _context.Lavori.Where(x => x.idLavoro == id).FirstOrDefault();
            return View(lavoro);
        }

        [HttpPost]
        public IActionResult LavoriUtenti_Edit(Lavoro lavoro)
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
        public IActionResult LavoriUtenti_Delete(int id)
        {
            Lavoro lavoro = _context.Lavori.Where(x => x.idLavoro == id).FirstOrDefault();
            return View(lavoro);
        }

        [HttpPost]
        public IActionResult LavoriUtenti_Delete(Lavoro lavoro)
        {
            if (lavoro != null)
            {
                return View("ConfirmDelete_LavoriUtente", lavoro);
            }
            return View("LavoriUtente");

        }

        [HttpPost]
        public IActionResult LavoriUtenti_ConfirmDelete(Lavoro lavoro)
        {
            if (lavoro != null)
            {
                _context.Lavori.Remove(lavoro);
                _context.SaveChanges();
                return RedirectToAction("LavoriUtenti");
            }
            return View("LavoriUtente");

        }




    }
}