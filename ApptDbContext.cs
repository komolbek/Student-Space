using System;
using StudentPlus.DomainModels;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using StudentPlus.Enums;
using System.IO;

namespace StudentPlus
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}     
    }
}

