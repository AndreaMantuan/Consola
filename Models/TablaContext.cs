using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace proyecto_consola.Models
{
    public partial class TablaContext : DbContext
    {
        public TablaContext()
        {
        }

        public TablaContext(DbContextOptions<TablaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-K4PVUIK8;Initial Catalog=Tabla;Integrated Security=True;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("cliente");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Apellido).HasMaxLength(100);

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Estado)
                    .HasMaxLength(100)
                    .HasColumnName("estado");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("date")
                    .HasColumnName("Fecha_nacimiento");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .HasColumnName("NOMBRE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
