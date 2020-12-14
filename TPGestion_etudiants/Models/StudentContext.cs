using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPGestion_etudiants.Models
{
    public class StudentContext : DbContext
    {
        
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }


    }
}
