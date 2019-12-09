using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.EF.DAL;

namespace Test.EF.DAL
{
    public class ClassInfo
    {
        public List<Class> GetClassInfo()
        {
            Model1 db = new Model1();
            List<Class> result=db.Class.ToList();
            return result;
        }

        public int AddClass(Class cla)
        {
            Model1 db = new Model1();
            db.Class.Add(cla);
            return db.SaveChanges();
        }

        public int DelClass(int id)
        {
            Model1 db = new Model1();
            Class delClass = db.Class.Find(id);
            db.Class.Remove(delClass);
            return db.SaveChanges();
        }

        public Class GetClassByID(int id)
        {
            Model1 db = new Model1();
            return db.Class.FirstOrDefault(r=>r.ClassId==id);
        }


        public int EditClass(Class cla)
        {
            Model1 db = new Model1();
            db.Entry(cla).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
