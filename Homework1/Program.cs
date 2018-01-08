using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Contexts;
using Homework1.Models;
using Homework1.DAL;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeworkDAL.StudentDAL.printStudents(HomeworkDAL.StudentDAL.getAllStudents());
            Console.Read();
        }
    }
}
