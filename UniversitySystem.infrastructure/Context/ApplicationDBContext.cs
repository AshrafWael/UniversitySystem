using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UniversitySystem.Data.Entities;

namespace UniversitySystem.infrastructure.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext() { }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        { }
        public DbSet<Student> students { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Subjects> subjects { get; set; }
        public DbSet<DepartmetSubject>  departmetsubjects { get; set; }
        public DbSet<StudentSubject> studentsubjects { get; set; }



    }
}
