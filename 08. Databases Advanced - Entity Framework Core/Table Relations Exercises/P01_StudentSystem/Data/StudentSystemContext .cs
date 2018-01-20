namespace P01_StudentSystem.Data
{
    using Microsoft.EntityFrameworkCore;
    using P01_StudentSystem.Data.Models;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
        {

        }

        public StudentSystemContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Homework> HomeworkSubmissions { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<StudentCourse> StudentCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConfigurationString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity
                    .Property(s => s.Name)
                    .HasMaxLength(100)
                    .IsUnicode()
                    .IsRequired();

                entity
                    .Property(s => s.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsRequired(false);

                entity
                    .Property(s => s.Birthday)
                    .IsRequired(false);

                entity
                    .Property(s => s.RegisteredOn)
                    .HasDefaultValueSql("GETDATE()");

                entity
                    .HasMany(s => s.HomeworkSubmissions)
                    .WithOne(h => h.Student)
                    .HasForeignKey(h => h.StudentId);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity
                    .Property(c => c.Name)
                    .HasMaxLength(80)
                    .IsUnicode()
                    .IsRequired();

                entity
                    .Property(c => c.Description)
                    .IsUnicode()
                    .IsRequired(false);

                entity
                    .HasMany(c => c.HomeworkSubmissions)
                    .WithOne(hs => hs.Course)
                    .HasForeignKey(hs => hs.CourseId);

                entity
                    .HasMany(c => c.Resources)
                    .WithOne(r => r.Course)
                    .HasForeignKey(r => r.CourseId);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity
                    .Property(r => r.Name)
                    .HasMaxLength(50)
                    .IsUnicode();

                entity
                    .Property(r => r.Url)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity
                    .Property(h => h.Content)
                    .IsUnicode(false);

                entity
                    .Property(h => h.SubmissionTime)
                    .HasDefaultValueSql("GETDATE()");

                entity
                    .ToTable("HomeworkSubmissions");
            });

            modelBuilder.Entity<StudentCourse>(entity =>
            {
                entity
                    .HasKey(k => new { k.StudentId,
                                       k.CourseId });

                entity
                    .HasOne(sc => sc.Student)
                    .WithMany(s => s.CourseEnrollments)
                    .HasForeignKey(sc => sc.StudentId);

                entity
                    .HasOne(sc => sc.Course)
                    .WithMany(s => s.StudentsEnrolled)
                    .HasForeignKey(sc => sc.CourseId);
            });
        }
    }
}
