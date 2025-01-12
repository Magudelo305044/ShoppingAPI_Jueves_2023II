﻿using Microsoft.EntityFrameworkCore;
using ShoppingAPI_Jueves_2023II.DAL.Entities;

namespace ShoppingAPI_Jueves_2023II.DAL
{
    public class DataBaseContext : DbContext
    {
        //Así me conecto a la BD por medio de este constructor
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
            
        }

        //Este método que es propio de EF CORE me sirve para configurar unos índices de cada campo de una tabla en BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Producto>().HasIndex(c => c.Name).IsUnique(); //Aquí creo un índice del campo Name para la tabla Countries
            modelBuilder.Entity<Categoria>().HasIndex("Name", "ProductoId").IsUnique(); //Indices Compuestos
        }

        #region DbSets

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        #endregion
    }
}
