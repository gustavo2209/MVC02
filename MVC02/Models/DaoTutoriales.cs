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
    }
}