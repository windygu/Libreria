﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades.Migracion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MigracionLaPazEntities : DbContext
    {
        public MigracionLaPazEntities()
            : base("name=MigracionLaPazEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TituloStockMigracion> TitulosStock { get; set; }
        public virtual DbSet<TituloMigracion> Titulos { get; set; }
    }
}