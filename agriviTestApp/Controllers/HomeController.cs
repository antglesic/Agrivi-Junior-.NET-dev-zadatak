using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using agriviTestApp.Models;

namespace agriviTestApp.Controllers
{
    public class HomeController : Controller
    {
        agriviDBEntities db = new agriviDBEntities();
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetList()
        {
            List<Spojevi> List = db.Spojevi.Select(x => new Spojevi
            {
                idSpoja = x.idSpoja,
                nazivSpoja = x.nazivSpoja,
                vodik = x.vodik,
                ugljik = x.ugljik,
                dusik = x.dusik,
                natrij = x.natrij,
                kisik = x.kisik
            }).ToList();

            return Json(List, JsonRequestBehavior.AllowGet);
        }

    }
}