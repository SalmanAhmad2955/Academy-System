using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_System
{
    class Teachersdb
    {
        public int Insert(Teacher teachers)
        {
           TutionCenterEntities db = new TutionCenterEntities();
            db.Teachers.Add(teachers);
            return db.SaveChanges();
        }
    }
}
