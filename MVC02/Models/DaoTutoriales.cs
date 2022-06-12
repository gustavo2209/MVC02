using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC02.Models
{
    public class DaoTutoriales
    {
        public List<tutoriales> tutorialesQry()
        {
            List<tutoriales> list;

            using (var db = new ModelTutoriales())
            {
                var query = from t in db.tutoriales select t;
                list = query.ToList<tutoriales>();
            }
            
            return list;
        }

        public void tutorialesIns(tutoriales t)
        {
            using(var db = new ModelTutoriales())
            {
                db.tutoriales.Add(t);
                db.SaveChanges();
            }
        }

        public void tutorialesDel(int idtutorial)
        {
            using (var db = new ModelTutoriales())
            {
                var tutorial = db.tutoriales.Find(idtutorial);

                db.tutoriales.Remove(tutorial);
                db.SaveChanges();
            }
        }

        public void tutorialesUpd(tutoriales t)
        {
            using (var db = new ModelTutoriales())
            {
                var tutorial = db.tutoriales.Find(t.idtutorial);

                tutorial.titulo = t.titulo;
                tutorial.tipo = t.tipo;
                tutorial.precio = t.precio;

                db.SaveChanges();
            }
        }
    }
}