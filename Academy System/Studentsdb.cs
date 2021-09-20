using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_System
{
    class Studentsdb
    {
        public int Insert(Student students)
        {
           TutionCenterEntities a = new TutionCenterEntities();
            a.Students.Add(students);
            return a.SaveChanges();
        }
    }
}
