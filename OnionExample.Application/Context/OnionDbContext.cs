using Microsoft.EntityFrameworkCore;
using OnionExample.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionExample.Application.Context
{
    public class OnionDbContext : DbContext
    {
        public OnionDbContext()
        {

        }
        public OnionDbContext(DbContextOptions<OnionDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<MovieModel> MovieModels { get; set; }
        public DbSet<MovieSessionsModel> MovieSessionsModels { get; set; }
        public DbSet<SalloonModel> SalloonModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql("Server=localhost;Database=oniondb;Uid=root;Pwd=root;", ServerVersion.AutoDetect("Server=localhost;Database=oniondb;Uid=root;Pwd=root;"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MovieModel>().HasKey(x => x.Id);
            modelBuilder.Entity<MovieSessionsModel>().HasKey(x => x.Id);
            modelBuilder.Entity<SalloonModel>().HasKey(x => x.Id);
        }
    }
}
