using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework1.Models;

namespace Homework1.Contexts
{
    public class HomeworkContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
