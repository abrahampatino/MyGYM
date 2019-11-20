using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Proyectov1.Models;

namespace Proyectov1.Data
{
    public partial class db_gym_webContext : DbContext
    {
        public db_gym_webContext()
        {
        }

        public db_gym_webContext(DbContextOptions<db_gym_webContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Aparato> Aparato { get; set; }
        public virtual DbSet<Mobiliario> Mobiliario { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Reservacionaparato> Reservacionaparato { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aparato>(entity =>
            {
                entity.HasKey(e => e.ApaId)
                    .HasName("PRIMARY");

                entity.ToTable("aparato");

                entity.Property(e => e.ApaId)
                    .HasColumnName("apa_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApaDescripcion)
                    .HasColumnName("apa_descripcion")
                    .HasColumnType("varchar(30)");

                entity.Property(e => e.ApaNombre)
                    .IsRequired()
                    .HasColumnName("apa_nombre")
                    .HasColumnType("varchar(20)");
            });

            modelBuilder.Entity<Mobiliario>(entity =>
            {
                entity.HasKey(e => new { e.MobId, e.ApaId })
                    .HasName("PRIMARY");

                entity.ToTable("mobiliario");

                entity.HasIndex(e => e.ApaId)
                    .HasName("fk_re_apa_mob");

                entity.HasIndex(e => e.MobApaNombre)
                    .HasName("mob_apa_nombre_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.MobId)
                    .HasColumnName("mob_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ApaId)
                    .HasColumnName("apa_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ApaEstatus)
                    .IsRequired()
                    .HasColumnName("apa_estatus")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'1\\''");

                entity.Property(e => e.MobApaNombre)
                    .IsRequired()
                    .HasColumnName("mob_apa_nombre")
                    .HasColumnType("varchar(25)");

                entity.HasOne(d => d.Apa)
                    .WithMany(p => p.Mobiliario)
                    .HasForeignKey(d => d.ApaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_re_apa");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => new { e.PerId, e.UsuId })
                    .HasName("PRIMARY");

                entity.ToTable("persona");

                entity.HasIndex(e => e.UsuId)
                    .HasName("fk_re_per_usu");

                entity.Property(e => e.PerId)
                    .HasColumnName("per_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuId)
                    .HasColumnName("usu_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EmpImss)
                    .HasColumnName("emp_imss")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.EmpRfc)
                    .HasColumnName("emp_rfc")
                    .HasColumnType("varchar(13)");

                entity.Property(e => e.InsoInst)
                    .HasColumnName("inso_inst")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PerMaterno)
                    .IsRequired()
                    .HasColumnName("per_materno")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.PerNombre)
                    .IsRequired()
                    .HasColumnName("per_nombre")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.PerNombre2)
                    .HasColumnName("per_nombre2")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.PerPaterno)
                    .IsRequired()
                    .HasColumnName("per_paterno")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.PerTipo)
                    .IsRequired()
                    .HasColumnName("per_tipo")
                    .HasColumnType("varchar(1)")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.SocAltura).HasColumnName("soc_altura");

                entity.Property(e => e.SocPeso).HasColumnName("soc_peso");

                entity.Property(e => e.SocTelefono)
                    .HasColumnName("soc_telefono")
                    .HasColumnType("varchar(10)");

                entity.Property(e => e.PerEstado)
                    .IsRequired()
                    .HasColumnName("per_estado")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'1\\''");

                entity.HasOne(d => d.Usu)
                    .WithMany(p => p.Persona)
                    .HasForeignKey(d => d.UsuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_re_usu");

            });

            modelBuilder.Entity<Reservacionaparato>(entity =>
            {
                entity.HasKey(e => new { e.ReaFecha, e.MobId, e.SocId })
                    .HasName("PRIMARY");

                entity.ToTable("reservacionaparato");

                entity.HasIndex(e => e.MobId)
                    .HasName("fk_re_res_mob");

                entity.HasIndex(e => e.SocId)
                    .HasName("fk_re_socio_idx");

                entity.Property(e => e.ReaFecha)
                    .HasColumnType("datetime");

                entity.Property(e => e.MobId)
                    .HasColumnName("mob_id")
                    .HasColumnName("rea_fecha")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SocId)
                    .HasColumnName("soc_id")
                    .HasColumnType("int(11)");
                    
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => new { e.RolId, e.UsuId })
                    .HasName("PRIMARY");

                entity.ToTable("rol");

                entity.HasIndex(e => e.UsuId)
                    .HasName("fk_re_rol_usu");

                entity.Property(e => e.RolId)
                    .HasColumnName("rol_id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsuId)
                    .HasColumnName("usu_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.RolAdmin)
                    .IsRequired()
                    .HasColumnName("rol_admin")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.RolEmployee)
                    .IsRequired()
                    .HasColumnName("rol_employee")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'0\\''");

                entity.Property(e => e.RolSocio)
                    .IsRequired()
                    .HasColumnName("rol_socio")
                    .HasColumnType("bit(1)")
                    .HasDefaultValueSql("'b\\'1\\''");

                entity.HasOne(d => d.Usu)
                    .WithMany(p => p.Rol)
                    .HasForeignKey(d => d.UsuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_re_us_ro");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuId)
                    .HasName("PRIMARY");

                entity.ToTable("usuario");

                entity.HasIndex(e => e.UsuName)
                    .HasName("usu_name_UNIQUE")
                    .IsUnique();

                entity.HasIndex(e => e.UsuCorr)
                    .HasName("usu_correo_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.UsuId)
                    .HasColumnName("usu_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UsuName)
                    .IsRequired()
                    .HasColumnName("usu_name")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.UsuCorr)
                    .IsRequired()
                    .HasColumnName("usu_correo")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.UsuPass)
                    .IsRequired()
                    .HasColumnName("usu_pass")
                    .HasColumnType("varchar(15)");
            });
        }
    }
}
