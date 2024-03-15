﻿using api.Data.Map;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class SigedespDBContex : DbContext
    {
        public SigedespDBContex(DbContextOptions<SigedespDBContex> options) : base(options) 
        {
        }

        public DbSet<TipoDespesaModel> TipoDespesa { get; set; }
        public DbSet<TipoInstituicaoModel> TipoInstituicao { get; set; }
        public DbSet<UnidadeMedidaModel> UnidadeMedida { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TipoDespesaMap());
            modelBuilder.ApplyConfiguration(new TipoInstituicaoMap());
            modelBuilder.ApplyConfiguration(new UnidadeMedidaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
