using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_System
{
    class DbAccess
    {
        public int Insert(Admin admin)
        {
           TutionCenterEntities db = new TutionCenterEntities();
            db.Admins.Add(admin);
            return db.SaveChanges();
        }
        public List<Student> SearchByName(string s)
        {
            return new  TutionCenterEntities().Students.Where(x => x.StudentName == s).ToList();
        }
        public int Update(string fullname, string password)
        {
           TutionCenterEntities db = new  TutionCenterEntities();

            var adm = db.Admins.Where(x => x.Name== fullname).FirstOrDefault();
            if (adm != null)
            {
                adm.Password=password;

            }
            return db.SaveChanges();
        }
        public int Login(String name,string password)
        {
           TutionCenterEntities db = new TutionCenterEntities();
            var log = db.Admins.Where(x => x.Name==name).FirstOrDefault();
            if(log.Password==password)
            {
                if (log.Name == name)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
