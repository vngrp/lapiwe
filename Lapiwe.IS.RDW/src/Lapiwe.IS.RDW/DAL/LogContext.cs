﻿using Microsoft.EntityFrameworkCore;


namespace Lapiwe.IS.RDW.DAL
{
    public class LogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySqlServer(@"Server=.\SQLEXPRESS; Database=Northwind;Trusted_Connection=True;");
        }
        public virtual DbSet<keuringsverzoek> KeuringsVerzoeken { get; set; }
        public virtual DbSet<keuringsregistratie> KeuringsRegistraties { get; set; }
    }
}
