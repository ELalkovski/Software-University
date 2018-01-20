namespace P01_HospitalDatabase.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class HospitalContext : DbContext
    {
        public HospitalContext()
        {
            
        }

        public HospitalContext(DbContextOptions options)
            : base(options)
        {
            
        }

        public DbSet<Diagnose> Diagnoses { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Visitation> Visitations { get; set; }
        public DbSet<PatientMedicament> PatientMedicaments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>(p =>
            {
                p.HasKey(k => k.PatientId);

                p.Property(pr => pr.FirstName)
                .HasMaxLength(50)
                .IsUnicode();

                p.Property(pr => pr.LastName)
                .HasMaxLength(50)
                .IsUnicode();

                p.Property(pr => pr.Address)
                .HasMaxLength(250)
                .IsUnicode();

                p.Property(pr => pr.Email)
                .HasMaxLength(80)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Visitation>(v =>
            {
                v.HasKey(k => k.VisitationId);

                v.Property(p => p.Comments)
                .HasMaxLength(250)
                .IsUnicode();

                v.Property(vp => vp.DoctorId)
                    .IsRequired(false);

                v.HasOne(vp => vp.Patient)
                    .WithMany(p => p.Visitations)
                    .HasForeignKey(vp => vp.PatientId);

                v.HasOne(d => d.Doctor)
                    .WithMany(fk => fk.Visitations)
                    .HasForeignKey(d => d.DoctorId);
            });

            modelBuilder.Entity<Diagnose>(d =>
            {
                d.HasKey(k => k.DiagnoseId);

                d.Property(p => p.Name)
                .HasMaxLength(50)
                .IsUnicode();

                d.Property(p => p.Comments)
                .HasMaxLength(250)
                .IsUnicode();

                d.HasOne(dp => dp.Patient)
                    .WithMany(p => p.Diagnoses)
                    .HasForeignKey(dp => dp.PatientId);
            });

            modelBuilder.Entity<Medicament>(m =>
            {
                m.HasKey(k => k.MedicamentId);

                m.Property(p => p.Name)
                .HasMaxLength(50)
                .IsUnicode();

                m.HasMany(mp => mp.Prescriptions)
                    .WithOne(pr => pr.Medicament)
                    .HasForeignKey(mp => mp.MedicamentId);
            });

            modelBuilder.Entity<PatientMedicament>(pm =>
            {
                pm.HasKey(k => new
                {
                    k.PatientId,
                    k.MedicamentId
                });

                pm.HasOne(p => p.Medicament)
                    .WithMany(m => m.Prescriptions)
                    .HasForeignKey(p => p.MedicamentId);

                pm.HasOne(p => p.Patient)
                    .WithMany(pat => pat.Prescriptions)
                    .HasForeignKey(p => p.PatientId);
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.HasKey(d => d.DoctorId);

                entity
                    .Property(d => d.Name)
                    .HasMaxLength(100)
                    .IsUnicode();

                entity
                    .Property(d => d.Specialty)
                    .HasMaxLength(100)
                    .IsUnicode();
            });
        }
    }
}