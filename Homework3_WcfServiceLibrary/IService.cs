using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Homework1.Models;

namespace Homework3_WcfServiceLibrary
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        StudentType getStudent(int id);
        
        [OperationContract]
        List<StudentType> getAllStudents();

        [OperationContract]
        Boolean addStudent(StudentType stuT);

        [OperationContract]
        Boolean deleteStudent(int id);
    }

    [DataContract]
    public class StudentType
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Sex Sex { get; set; }
        [DataMember]
        public int Age { get; set; }
        public StudentType() { }

        public StudentType(Student stu)
        {
            this.Id = stu.Id;
            this.Name = stu.Name;
            this.Age = stu.Age;
            this.Sex = stu.Sex;
        }
    }
}
