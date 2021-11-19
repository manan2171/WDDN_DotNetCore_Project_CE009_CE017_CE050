using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SMVC.Models;

namespace SMVC.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Branch> Branches { get; set; }

        public DbSet<Subject> Subject { get; set; }
    }
}
