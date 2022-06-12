using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC02.Models;

namespace MVC02.Controllers
{
    public class HomeController : Controller
    {
        private DaoTutoriales daoTutoriales;

        public HomeController()
        {
            daoTutoriales = new DaoTutoriales();
        }

        public ActionResult Index()
        {
            string accion = Request["accion"]; // INS/DEL/UPD

            if(accion != null)
            {
                switch (accion)
                {
                    case "INS":
                        break;
                    case "UPD":
                        break;
                    case "DEL":
                        break;
                }
            }

            List<tutoriales> list = daoTutoriales.tutorialesQry();
            ViewBag.Lista = list;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}