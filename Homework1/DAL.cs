using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Contexts;
using Homework1.Models;

namespace Homework1.DAL
{
    public class HomeworkDAL
    {
        private static HomeworkContext db = new HomeworkContext();
        public static class StudentDAL
        {
            // Get
            static public Student getStudent(int id)
            {
                return db.Students.Find(id);
            }
            static public List<Student> getStudents(string name)
            {
                var query = from b in db.Students
                       where b.Name == name
                       select b;
                return query.ToList<Student>();
            }
            static public List<Student> getAllStudents()
            {
                return db.Students.ToList<Student>();
            }

            // Add
            static public Student addStudent(string name, int age, Sex sex)
            {
                var stu =  db.Students.Add(new Student()
                {
                    Name = name,
                    Age = age,
                    Sex = sex
                });
                db.SaveChanges();

                return stu;
            }

            // Update
            static public Student editStudent(int id, string name, int age, Sex sex)
            {
                var stu = getStudent(id);

                if (stu != null)
                {
                    stu.Name = name;
                    stu.Age = age;
                    stu.Sex = sex;
                    db.SaveChanges();

                    return stu;
                }

                return null;
            }

            // Delete
            static public void deleteStudent(int id)
            {
                var stu = getStudent(id);
                if (stu != null)
                {
                    db.Students.Attach(stu);
                    db.Students.Remove(stu);
                    db.SaveChanges();
                }
            }

            // Print
            static public void printStudent(Student stu)
            {
                Console.WriteLine($"Student: Id - {stu.Id}; Name - {stu.Name}; Age - {stu.Age}; Sex - {stu.Sex}");
            }
            static public void printStudents(string name)
            {
                printStudents(getStudents(name));
            }
            static public void printStudents(List<Student> stus)
            {
                foreach (var stu in stus)
                {
                    printStudent(stu);
                }
            }
        }
    }
}
