using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Won7L16.Models;

namespace Won7L16.Data
{
    internal class StudentDbContext:DbContext
    {
        private const string DbUrl = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\FastTrackIT\Cursuri\Cursul 16\Won7L16\StudentsDb.mdf"";Integrated Security=True";
        public DbSet<Student> Students { get; set; }

        public StudentDbContext() 
        { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(DbUrl);
        }
    }
}
