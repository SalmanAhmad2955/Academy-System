using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_System
{
    class Coursesdb
    {
        public int Insert(Cours cours)
        {
           TutionCenterEntities db = new TutionCenterEntities();
            db.Courses.Add(cours);
            return db.SaveChanges();
        }
    }
}
