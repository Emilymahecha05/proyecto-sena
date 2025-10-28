using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mi_proyecto_sena.Models;
using Microsoft.EntityFrameworkCore;

namespace mi_proyecto_sena.Data
{
    public class DBcontext : DbContext
    {
        public DBcontext(DbContextOptions<DBcontext> options) : base(options) { }
        public DbSet<usuarioModel> usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<usuarioModel>().HasKey(u => u.usuario_Id);
            modelBuilder.Entity<usuarioModel>().Property(u => u.usuario_Id).ValueGeneratedOnAdd();
        }
    }
}  