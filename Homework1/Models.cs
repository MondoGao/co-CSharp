using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.Models
{
    public enum Sex
    {
        Male, Female
    }
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Sex Sex { get; set; }
        public int Age { get; set; }
    }
}
