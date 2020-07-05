namespace STG.DataAccess
{
    using Microsoft.EntityFrameworkCore;
    using STG.Model;

    public partial class STGContext : DbContext
    {
        public STGContext()
        {
        }

        public STGContext(DbContextOptions<STGContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accion> Accion { get; set; }
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<CartasPorte> CartasPorte { get; set; }
        public virtual DbSet<DetalleServicioAdicional> DetalleServicioAdicional { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<ModuloObjetoAccion> ModuloObjetoAccion { get; set; }
        public virtual DbSet<Objeto> Objeto { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<SolicitudServicio> SolicitudServicio { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioActividad> UsuarioActividad { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Data Source=Mauro\\SQLEXPRESS; Initial Catalog=STG; Integrated Security=True; User Id=sa; Password=12345678");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accion>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__Accion__9A39F97CC0F02354");

                entity.Property(e => e.AccId)
                    .HasColumnName("acc_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccDescripcion)
                    .IsRequired()
                    .HasColumnName("acc_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.HasKey(e => e.ActId)
                    .HasName("PK__Activida__EBC93CEDAFB097A1");

                entity.Property(e => e.ActId)
                    .HasColumnName("act_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActDescripcion)
                    .IsRequired()
                    .HasColumnName("act_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CartasPorte>(entity =>
            {
                entity.HasKey(e => e.CpoId)
                    .HasName("PK__CartasPo__715E2997DEA47F93");

                entity.Property(e => e.CpoId).HasColumnName("cpo_Id");

                entity.Property(e => e.CpoCosecha).HasColumnName("cpo_Cosecha");

                entity.Property(e => e.CpoCtg)
                    .IsRequired()
                    .HasColumnName("cpo_CTG")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CpoDestino)
                    .IsRequired()
                    .HasColumnName("cpo_Destino")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpoEstado)
                    .IsRequired()
                    .HasColumnName("cpo_Estado")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CpoFechaDescarga)
                    .HasColumnName("cpo_FechaDescarga")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpoFechaEmision)
                    .HasColumnName("cpo_FechaEmision")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpoKgDescargados).HasColumnName("cpo_KgDescargados");

                entity.Property(e => e.CpoKgProcedencia).HasColumnName("cpo_KgProcedencia");

                entity.Property(e => e.CpoNro).HasColumnName("cpo_Nro");

                entity.Property(e => e.CpoPatenteTransporte)
                    .IsRequired()
                    .HasColumnName("cpo_PatenteTransporte")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CpoPduId).HasColumnName("cpo_pdu_Id");

                entity.Property(e => e.CpoProcedencia)
                    .IsRequired()
                    .HasColumnName("cpo_Procedencia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CpoUsuCodigoComprador).HasColumnName("cpo_usu_CodigoComprador");

                entity.Property(e => e.CpoUsuCodigoEntregador).HasColumnName("cpo_usu_CodigoEntregador");

                entity.Property(e => e.CpoUsuCodigoVendedor).HasColumnName("cpo_usu_CodigoVendedor");

                entity.HasOne(d => d.CpoPdu)
                    .WithMany(p => p.CartasPorte)
                    .HasForeignKey(d => d.CpoPduId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CartasPor__cpo_p__300424B4");

                entity.HasOne(d => d.CpoUsuCodigoCompradorNavigation)
                    .WithMany(p => p.CartasPorteCpoUsuCodigoCompradorNavigation)
                    .HasForeignKey(d => d.CpoUsuCodigoComprador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CartasPor__cpo_u__31EC6D26");

                entity.HasOne(d => d.CpoUsuCodigoEntregadorNavigation)
                    .WithMany(p => p.CartasPorteCpoUsuCodigoEntregadorNavigation)
                    .HasForeignKey(d => d.CpoUsuCodigoEntregador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CartasPor__cpo_u__32E0915F");

                entity.HasOne(d => d.CpoUsuCodigoVendedorNavigation)
                    .WithMany(p => p.CartasPorteCpoUsuCodigoVendedorNavigation)
                    .HasForeignKey(d => d.CpoUsuCodigoVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CartasPor__cpo_u__30F848ED");
            });

            modelBuilder.Entity<DetalleServicioAdicional>(entity =>
            {
                entity.HasKey(e => e.DsaId)
                    .HasName("PK__DetalleS__2C16EB8EB3E42A73");

                entity.Property(e => e.DsaId).HasColumnName("dsa_Id");

                entity.Property(e => e.DsaAutoriza).HasColumnName("dsa_Autoriza");

                entity.Property(e => e.DsaImporte)
                    .HasColumnName("dsa_Importe")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DsaImporteDef)
                    .HasColumnName("dsa_ImporteDef")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DsaImporteKilos)
                    .HasColumnName("dsa_ImporteKilos")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DsaImporteKilosDef)
                    .HasColumnName("dsa_ImporteKilosDef")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DsaSerId).HasColumnName("dsa_ser_Id");

                entity.Property(e => e.DsaSolId).HasColumnName("dsa_sol_Id");

                entity.Property(e => e.DsaTarifaPorTn)
                    .HasColumnName("dsa_TarifaPorTn")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.DsaSer)
                    .WithMany(p => p.DetalleServicioAdicional)
                    .HasForeignKey(d => d.DsaSerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleSe__dsa_s__38996AB5");

                entity.HasOne(d => d.DsaSol)
                    .WithMany(p => p.DetalleServicioAdicional)
                    .HasForeignKey(d => d.DsaSolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DetalleSe__dsa_s__398D8EEE");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.ModId)
                    .HasName("PK__Modulo__656687D66B5BF8AE");

                entity.Property(e => e.ModId)
                    .HasColumnName("mod_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModDescripcion)
                    .IsRequired()
                    .HasColumnName("mod_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModuloObjetoAccion>(entity =>
            {
                entity.HasKey(e => e.MoaId)
                    .HasName("PK__ModuloOb__7A0B8760BAFB12E7");

                entity.Property(e => e.MoaId).HasColumnName("moa_Id");

                entity.Property(e => e.MoaAccId).HasColumnName("moa_acc_Id");

                entity.Property(e => e.MoaModId).HasColumnName("moa_mod_Id");

                entity.Property(e => e.MoaObjId).HasColumnName("moa_obj_Id");

                entity.HasOne(d => d.MoaAcc)
                    .WithMany(p => p.ModuloObjetoAccion)
                    .HasForeignKey(d => d.MoaAccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ModuloObj__moa_a__440B1D61");

                entity.HasOne(d => d.MoaMod)
                    .WithMany(p => p.ModuloObjetoAccion)
                    .HasForeignKey(d => d.MoaModId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ModuloObj__moa_m__4222D4EF");

                entity.HasOne(d => d.MoaObj)
                    .WithMany(p => p.ModuloObjetoAccion)
                    .HasForeignKey(d => d.MoaObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ModuloObj__moa_o__4316F928");
            });

            modelBuilder.Entity<Objeto>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Objeto__9FA39FEB74086041");

                entity.Property(e => e.ObjId).HasColumnName("obj_Id");

                entity.Property(e => e.ObjDescripcion)
                    .IsRequired()
                    .HasColumnName("obj_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.PduId)
                    .HasName("PK__Producto__0622590EB7C6B9FA");

                entity.Property(e => e.PduId)
                    .HasColumnName("pdu_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PduDescripcion)
                    .IsRequired()
                    .HasColumnName("pdu_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.SerId)
                    .HasName("PK__Servicio__62860C33605F5E5C");

                entity.Property(e => e.SerId)
                    .HasColumnName("ser_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SerDescripcion)
                    .IsRequired()
                    .HasColumnName("ser_Descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SerOpcional).HasColumnName("ser_Opcional");
            });

            modelBuilder.Entity<SolicitudServicio>(entity =>
            {
                entity.HasKey(e => e.SolId)
                    .HasName("PK__Solicitu__9A7B3583E6582980");

                entity.Property(e => e.SolId).HasColumnName("sol_Id");

                entity.Property(e => e.SolCalidadComoServicio).HasColumnName("sol_CalidadComoServicio");

                entity.Property(e => e.SolFechaAutorizacion)
                    .HasColumnName("sol_FechaAutorizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.SolFechaEmision)
                    .HasColumnName("sol_FechaEmision")
                    .HasColumnType("datetime");

                entity.Property(e => e.SolFormaPagoAdicionales)
                    .IsRequired()
                    .HasColumnName("sol_FormaPagoAdicionales")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SolImporteRebaja)
                    .HasColumnName("sol_ImporteRebaja")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SolKilosRebaja).HasColumnName("sol_KilosRebaja");

                entity.Property(e => e.SolPorcRebaja)
                    .HasColumnName("sol_PorcRebaja")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SolUsuIdAcondicionador).HasColumnName("sol_usu_IdAcondicionador");

                entity.HasOne(d => d.SolUsuIdAcondicionadorNavigation)
                    .WithMany(p => p.SolicitudServicio)
                    .HasForeignKey(d => d.SolUsuIdAcondicionador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Solicitud__sol_u__35BCFE0A");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuId)
                    .HasName("PK__Usuario__43056304D4C85D8E");

                entity.Property(e => e.UsuId)
                    .HasColumnName("usu_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UsuCuit)
                    .IsRequired()
                    .HasColumnName("usu_CUIT")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuEstado)
                    .IsRequired()
                    .HasColumnName("usu_Estado")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuLocalidad)
                    .IsRequired()
                    .HasColumnName("usu_Localidad")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuLogin)
                    .IsRequired()
                    .HasColumnName("usu_Login")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuMail)
                    .IsRequired()
                    .HasColumnName("usu_Mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuNombre)
                    .IsRequired()
                    .HasColumnName("usu_Nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuNroContacto)
                    .IsRequired()
                    .HasColumnName("usu_NroContacto")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuPass)
                    .IsRequired()
                    .HasColumnName("usu_Pass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuRol)
                    .IsRequired()
                    .HasColumnName("usu_Rol")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuarioActividad>(entity =>
            {
                entity.HasKey(e => new { e.UsaUsuCodigo, e.UsaActId })
                    .HasName("PK__UsuarioA__CCB82F92B815508B");

                entity.Property(e => e.UsaUsuCodigo).HasColumnName("usa_usu_Codigo");

                entity.Property(e => e.UsaActId).HasColumnName("usa_act_Id");

                entity.Property(e => e.UsaEstado)
                    .IsRequired()
                    .HasColumnName("usa_Estado")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsaAct)
                    .WithMany(p => p.UsuarioActividad)
                    .HasForeignKey(d => d.UsaActId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UsuarioAc__usa_a__2D27B809");

                entity.HasOne(d => d.UsaUsuCodigoNavigation)
                    .WithMany(p => p.UsuarioActividad)
                    .HasForeignKey(d => d.UsaUsuCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UsuarioAc__usa_u__2C3393D0");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
