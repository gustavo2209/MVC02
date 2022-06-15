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

                        string titulo = Request["titulo"];
                        string tipo = Request["tipo"];
                        decimal precio = Convert.ToDecimal(Request["precio"]);

                        tutoriales t = new tutoriales();
                        t.titulo = titulo;
                        t.tipo = tipo;
                        t.precio = precio;

                        daoTutoriales.tutorialesIns(t);

                        break;
                    case "UPD":
                        int idtutorial = Convert.ToInt32(Request["idtutorial"]);
                        titulo = Request["titulo"];
                        tipo = Request["tipo"];
                        precio = Convert.ToDecimal(Request["precio"]);

                        t = new tutoriales();
                        t.idtutorial = idtutorial;
                        t.titulo = titulo;
                        t.tipo = tipo;
                        t.precio = precio;

                        daoTutoriales.tutorialesUpd(t);
                        break;
                    case "DEL":
                        idtutorial = Convert.ToInt32(Request["idtutorial"]);
                        daoTutoriales.tutorialesDel(idtutorial);
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