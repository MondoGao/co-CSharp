using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static Homework1.DAL.HomeworkDAL;

namespace Homework3_WcfServiceLibrary
{
    public class Service : IService
    {
        public bool addStudent(StudentType stuT)
        {
            try {
                StudentDAL.addStudent(stuT.Name, stuT.Age, stuT.Sex);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool deleteStudent(int id)
        {
            try
            {
                StudentDAL.deleteStudent(id);
            }
            catch
            {
                return false;
            }

            return true;
        }

        public List<StudentType> getAllStudents()
        {
            var stus = StudentDAL.getAllStudents();
            var stuTs = new List<StudentType>();

            foreach (var stu in stus)
            {
                stuTs.Add(new StudentType(stu));
            }

            return stuTs;
        }

        public StudentType getStudent(int id)
        {
            var stu = StudentDAL.getStudent(id);

            if (stu == null)
            {
                throw new ArgumentNullException("no student");
            }

            return new StudentType(stu);
        }
    }
}
