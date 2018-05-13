using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agriviTestApp.Models;
using System.Data.Entity;

namespace agriviTestApp.Controllers
{
    public class compoundsController : Controller
    {
        // GET: compounds
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            using(agriviDBEntities db = new agriviDBEntities())
            {
                List<Spojevi> list = db.Spojevi.ToList<Spojevi>();
                return Json(new { data = list }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if(id== 0)
            {
                return View(new Spojevi());
            }
            else
            {
                using(agriviDBEntities db = new agriviDBEntities())
                {
                    return View(db.Spojevi.Where(x => x.idSpoja == id).FirstOrDefault<Spojevi>());
                }
            }
        }

        [HttpPost]
        public ActionResult AddOrEdit(Spojevi compound)
        {
            
            using (agriviDBEntities db = new agriviDBEntities())
            {
                if (compound.idSpoja == 0)
                {
                    List<Spojevi> list = db.Spojevi.ToList<Spojevi>();
                    if(list.Count > 0)
                    {
                        compound.idSpoja = list.Last().idSpoja + 1;
                    }
                    db.Spojevi.Add(compound);
                    db.SaveChanges();
                    return Json(new { success = true, message = "Added!", JsonRequestBehavior.AllowGet });
                }
                else
                {
                    db.Entry(compound).State = EntityState.Modified;
                    db.SaveChanges();
                    return Json(new { success = true, message = "Updated!", JsonRequestBehavior.AllowGet });
                }
            }
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            using(agriviDBEntities db = new agriviDBEntities())
            {
                Spojevi compound = db.Spojevi.Where(x => x.idSpoja == id).FirstOrDefault<Spojevi>();
                db.Spojevi.Remove(compound);
                db.SaveChanges();
                return Json(new { succes = true, message = "Deleted!", JsonRequestBehavior.AllowGet });
            }
        }
    }
}