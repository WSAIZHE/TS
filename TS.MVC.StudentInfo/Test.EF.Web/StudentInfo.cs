using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.EF.DAL;

namespace Test.EF.DAL
{
    public class StudentInfo
    {
        public List<Student> GetstudentInfo()
        {
            Model1 db= new Model1();
            List<Student> result = db.Student.ToList();
            return result;
        }

        public int AddStudet(Student stu)
        {
            Model1 db = new Model1();
            db.Student.Add(stu);
            return db.SaveChanges();
        }

        public List<Class> GetClasses()
        {
            Model1 db = new Model1();
            List<Class> result=db.Class.ToList();
            return result;
        }

        public Student GetStudentID(int id)
        {
            Model1 db = new Model1();
            return db.Student.FirstOrDefault(r=>r.Id==id);
        }

        public int EditStudent(Student stu)
        {
            Model1 db = new Model1();
            db.Entry(stu).State = System.Data.Entity.EntityState.Modified;
            return db.SaveChanges();
        }

        public int DelStudent(int id)
        {
            Model1 db = new Model1();
            Student student= db.Student.Find(id);
            db.Student.Remove(student);
            return db.SaveChanges();
        }
    }
}
