﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBSISTEMARESTAURANTEEntities : DbContext
    {
        public DBSISTEMARESTAURANTEEntities()
            : base("name=DBSISTEMARESTAURANTEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CATEGORIA> CATEGORIA { get; set; }
        public DbSet<CLIENTE> CLIENTE { get; set; }
        public DbSet<DETALLECOMPRA> DETALLECOMPRA { get; set; }
        public DbSet<DETALLEVENTA> DETALLEVENTA { get; set; }
        public DbSet<INGREDIENTE> INGREDIENTE { get; set; }
        public DbSet<PERMISO> PERMISO { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<Productoss> Productoss { get; set; }
        public DbSet<PROVEEDOR> PROVEEDOR { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<VENTA> VENTA { get; set; }
        public DbSet<ROL> ROL { get; set; }
    }
}
