#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMVC.Models;

namespace StudentMVC.Data
{
    public class StudentMVCContext : DbContext
    {
        public StudentMVCContext (DbContextOptions<StudentMVCContext> options)
            : base(options)
        {
        }

        public DbSet<StudentMVC.Models.Students> Students { get; set; }
    }
}
