using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TECAir_API
{
    public partial class TECAirContext : DbContext
    {
        public TECAirContext()
        {
        }

        public TECAirContext(DbContextOptions<TECAirContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AsientoWeb> Asientos { get; set; } = null!;
        public virtual DbSet<Avion> Avions { get; set; } = null!;
        public virtual DbSet<Escala> Escalas { get; set; } = null!;
        public virtual DbSet<Estudiante> Estudiantes { get; set; } = null!;
        public virtual DbSet<Maletum> Maleta { get; set; } = null!;
        public virtual DbSet<Pasajero> Pasajeros { get; set; } = null!;
        public virtual DbSet<PromocionWeb> Promocions { get; set; } = null!;
        public virtual DbSet<Reservacion> Reservacions { get; set; } = null!;
        public virtual DbSet<Tiquete> Tiquetes { get; set; } = null!;
        public virtual DbSet<Trabajador> Trabajadors { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Vuelo> Vuelos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=TECAir;Username=postgres;Password=tecair");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AsientoWeb>(entity =>
            {
                entity.HasKey(e => e.NoAsiento)
                    .HasName("asiento_pkey");

                entity.ToTable("asiento");

                entity.Property(e => e.NoAsiento).HasColumnName("no_asiento");

                entity.Property(e => e.NoVuelo).HasColumnName("no_vuelo");

                entity.Property(e => e.Ubicacion)
                    .HasMaxLength(10)
                    .HasColumnName("ubicacion");

                entity.HasOne(d => d.NoVueloNavigation)
                    .WithMany(p => p.Asientos)
                    .HasForeignKey(d => d.NoVuelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("no_vuelo");
            });

            modelBuilder.Entity<Avion>(entity =>
            {
                entity.HasKey(e => e.Matricula)
                    .HasName("avion_pkey");

                entity.ToTable("avion");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(20)
                    .HasColumnName("matricula");

                entity.Property(e => e.AvNombre)
                    .HasMaxLength(30)
                    .HasColumnName("av_nombre");

                entity.Property(e => e.Capacidad).HasColumnName("capacidad");
            });

            modelBuilder.Entity<Escala>(entity =>
            {
                entity.HasKey(e => e.NoEscala)
                    .HasName("escala_pkey");

                entity.ToTable("escala");

                entity.Property(e => e.NoEscala).HasColumnName("no_escala");

                entity.Property(e => e.Escala1)
                    .HasMaxLength(60)
                    .HasColumnName("escala");

                entity.Property(e => e.NoVuelo).HasColumnName("no_vuelo");

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.HasOne(d => d.NoVueloNavigation)
                    .WithMany(p => p.Escalas)
                    .HasForeignKey(d => d.NoVuelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("no_vuelo");
            });

            modelBuilder.Entity<Estudiante>(entity =>
            {
                entity.HasKey(e => e.Carne)
                    .HasName("estudiante_pkey");

                entity.ToTable("estudiante");

                entity.Property(e => e.Carne).HasColumnName("carne");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Universidad)
                    .HasMaxLength(60)
                    .HasColumnName("universidad");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Estudiantes)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("id_usuario");
            });

            modelBuilder.Entity<Maletum>(entity =>
            {
                entity.HasKey(e => e.NoMaleta)
                    .HasName("maleta_pkey");

                entity.ToTable("maleta");

                entity.Property(e => e.NoMaleta).HasColumnName("no_maleta");

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .HasColumnName("color");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.NoVuelo).HasColumnName("no_vuelo");

                entity.Property(e => e.Peso).HasColumnName("peso");

                entity.HasOne(d => d.DniNavigation)
                    .WithMany(p => p.Maleta)
                    .HasForeignKey(d => d.Dni)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("dni");

                entity.HasOne(d => d.NoVueloNavigation)
                    .WithMany(p => p.Maleta)
                    .HasForeignKey(d => d.NoVuelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("no_vuelo");
            });

            modelBuilder.Entity<Pasajero>(entity =>
            {
                entity.HasKey(e => e.Dni)
                    .HasName("pasajero_pkey");

                entity.ToTable("pasajero");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.CantMaletas).HasColumnName("cant_maletas");

                entity.Property(e => e.Chequeado).HasColumnName("chequeado");

                entity.Property(e => e.NoTransaccion).HasColumnName("no_transaccion");

                entity.Property(e => e.PApellido1)
                    .HasMaxLength(20)
                    .HasColumnName("p_apellido1");

                entity.Property(e => e.PApellido2)
                    .HasMaxLength(20)
                    .HasColumnName("p_apellido2");

                entity.Property(e => e.PNombre)
                    .HasMaxLength(20)
                    .HasColumnName("p_nombre");

                entity.HasOne(d => d.NoTransaccionNavigation)
                    .WithMany(p => p.Pasajeros)
                    .HasForeignKey(d => d.NoTransaccion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("no_transaccion");
            });

            modelBuilder.Entity<PromocionWeb>(entity =>
            {
                entity.HasKey(e => e.NoPromocion)
                    .HasName("promocion_pkey");

                entity.ToTable("promocion");

                entity.Property(e => e.NoPromocion).HasColumnName("no_promocion");

                entity.Property(e => e.NoVuelo).HasColumnName("no_vuelo");

                entity.Property(e => e.PAno)
                    .HasMaxLength(10)
                    .HasColumnName("p_ano");

                entity.Property(e => e.PDia)
                    .HasMaxLength(10)
                    .HasColumnName("p_dia");

                entity.Property(e => e.PMes)
                    .HasMaxLength(10)
                    .HasColumnName("p_mes");

                entity.Property(e => e.Periodo).HasColumnName("periodo");

                entity.Property(e => e.Porcentaje).HasColumnName("porcentaje");

                entity.Property(e => e.Url)
                    .HasMaxLength(512)
                    .HasColumnName("url");

                entity.HasOne(d => d.NoVueloNavigation)
                    .WithMany(p => p.Promocions)
                    .HasForeignKey(d => d.NoVuelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("no_vuelo");
            });

            modelBuilder.Entity<Reservacion>(entity =>
            {
                entity.HasKey(e => e.NoReservacion)
                    .HasName("reservacion_pkey");

                entity.ToTable("reservacion");

                entity.Property(e => e.NoReservacion).HasColumnName("no_reservacion");

                entity.Property(e => e.Cancelado).HasColumnName("cancelado");

                entity.Property(e => e.IdTrabajador)
                    .HasMaxLength(20)
                    .HasColumnName("id_trabajador");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.NoVuelo).HasColumnName("no_vuelo");

                entity.HasOne(d => d.IdTrabajadorNavigation)
                    .WithMany(p => p.Reservacions)
                    .HasForeignKey(d => d.IdTrabajador)
                    .HasConstraintName("id_trabajador");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Reservacions)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("id_usuario");

                entity.HasOne(d => d.NoVueloNavigation)
                    .WithMany(p => p.Reservacions)
                    .HasForeignKey(d => d.NoVuelo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("no_vuelo");
            });

            modelBuilder.Entity<Tiquete>(entity =>
            {
                entity.HasKey(e => e.NoTransaccion)
                    .HasName("tiquete_pkey");

                entity.ToTable("tiquete");

                entity.Property(e => e.NoTransaccion).HasColumnName("no_transaccion");

                entity.Property(e => e.Abordaje).HasColumnName("abordaje");

                entity.Property(e => e.NoAsiento).HasColumnName("no_asiento");

                entity.Property(e => e.NoReservacion).HasColumnName("no_reservacion");

                entity.Property(e => e.TAno)
                    .HasMaxLength(20)
                    .HasColumnName("t_ano");

                entity.Property(e => e.TDia)
                    .HasMaxLength(20)
                    .HasColumnName("t_dia");

                entity.Property(e => e.TMes)
                    .HasMaxLength(20)
                    .HasColumnName("t_mes");

                entity.HasOne(d => d.NoAsientoNavigation)
                    .WithMany(p => p.Tiquetes)
                    .HasForeignKey(d => d.NoAsiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("no_asiento");

                entity.HasOne(d => d.NoReservacionNavigation)
                    .WithMany(p => p.Tiquetes)
                    .HasForeignKey(d => d.NoReservacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("no_reservacion");
            });

            modelBuilder.Entity<Trabajador>(entity =>
            {
                entity.HasKey(e => e.IdTrabajador)
                    .HasName("trabajador_pkey");

                entity.ToTable("trabajador");

                entity.Property(e => e.IdTrabajador)
                    .HasMaxLength(20)
                    .HasColumnName("id_trabajador");

                entity.Property(e => e.TContrasena)
                    .HasMaxLength(20)
                    .HasColumnName("t_contrasena");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("usuario_pkey");

                entity.ToTable("usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Correo)
                    .HasMaxLength(40)
                    .HasColumnName("correo");

                entity.Property(e => e.Telefono).HasColumnName("telefono");

                entity.Property(e => e.UApellido1)
                    .HasMaxLength(20)
                    .HasColumnName("u_apellido1");

                entity.Property(e => e.UApellido2)
                    .HasMaxLength(20)
                    .HasColumnName("u_apellido2");

                entity.Property(e => e.UContrasena)
                    .HasMaxLength(20)
                    .HasColumnName("u_contrasena");

                entity.Property(e => e.UNombre)
                    .HasMaxLength(20)
                    .HasColumnName("u_nombre");
            });

            modelBuilder.Entity<Vuelo>(entity =>
            {
                entity.HasKey(e => e.NoVuelo)
                    .HasName("vuelo_pkey");

                entity.ToTable("vuelo");

                entity.Property(e => e.NoVuelo).HasColumnName("no_vuelo");

                entity.Property(e => e.Cerrado).HasColumnName("cerrado");

                entity.Property(e => e.CosteVuelo).HasColumnName("coste_vuelo");

                entity.Property(e => e.Destino)
                    .HasMaxLength(256)
                    .HasColumnName("destino");

                entity.Property(e => e.HLlegada)
                    .HasMaxLength(10)
                    .HasColumnName("h_llegada");

                entity.Property(e => e.HSalida)
                    .HasMaxLength(10)
                    .HasColumnName("h_salida");

                entity.Property(e => e.Matricula)
                    .HasMaxLength(20)
                    .HasColumnName("matricula");

                entity.Property(e => e.Origen)
                    .HasMaxLength(256)
                    .HasColumnName("origen");

                entity.Property(e => e.PrtAbordaje)
                    .HasMaxLength(10)
                    .HasColumnName("prt_abordaje");

                entity.Property(e => e.VAno)
                    .HasMaxLength(10)
                    .HasColumnName("v_ano");

                entity.Property(e => e.VDia)
                    .HasMaxLength(10)
                    .HasColumnName("v_dia");

                entity.Property(e => e.VMes)
                    .HasMaxLength(10)
                    .HasColumnName("v_mes");

                entity.HasOne(d => d.MatriculaNavigation)
                    .WithMany(p => p.Vuelos)
                    .HasForeignKey(d => d.Matricula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("matricula");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
