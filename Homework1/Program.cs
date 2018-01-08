using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Contexts;
using Homework1.Models;
using static Homework1.DAL.HomeworkDAL;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Jiang Gaohua";
            var stus = StudentDAL.getStudents(name);
            if (stus.Count == 0)
            {
                StudentDAL.addStudent(name, 20, Sex.Male);
            }

            StudentDAL.printStudents(StudentDAL.getAllStudents());
            Console.Read();
        }
    }
}
