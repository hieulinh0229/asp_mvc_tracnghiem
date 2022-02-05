
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using TRACNGHIEMONLINE.Models;

namespace TRACNGHIEMONLINE.DAL
{
    public class TracNghiemDbContext : DbContext {
        public TracNghiemDbContext(DbContextOptions<TracNghiemDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Permission> Permissions{  get; set;}
        public DbSet<Class> Classes{  get; set;}
        public DbSet<Question> Questions{  get; set;}
        public DbSet<Score> Scores{  get; set;}
        public DbSet<Status> Statuses{  get; set;}
        public DbSet<Student> Students{  get; set;}
        public DbSet<Subject> Subjects{  get; set;}
        public DbSet<Test> Tests{  get; set;}
    }
}
