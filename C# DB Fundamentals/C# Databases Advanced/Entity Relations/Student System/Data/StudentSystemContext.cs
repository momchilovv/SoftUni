using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext() { }

        public StudentSystemContext(DbContextOptions<StudentSystemContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Homework> Homeworks { get; set; }

        public DbSet<StudentCourse> StudentsCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.,1433;Database=StudentSystem;User Id=sa;Password=NOPASSWORD");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.StudentId);

                entity.Property(s => s.Name)
                .HasMaxLength(100)
                .IsUnicode(true);

                entity.Property(s => s.PhoneNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .IsUnicode(false);

                entity.Property(s => s.RegisteredOn)
                .HasColumnType("datetime2");

                entity.Property(s => s.Birthday)
                .HasColumnType("datetime2")
                .IsRequired(false);

                //entity.HasMany(sc => sc.StudentsCourses)
                //.WithOne(s => s.Student)
                //.HasForeignKey(s => s.StudentId);

                //entity.HasMany(h => h.Homeworks)
                //.WithOne(s => s.Student)
                //.HasForeignKey(s => s.StudentId);
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(c => c.CourseId);

                entity.Property(c => c.Name)
                .HasMaxLength(80)
                .IsUnicode(true);

                entity.Property(c => c.Description)
                .IsUnicode(true)
                .IsRequired(false);

                entity.Property(c => c.StartDate)
                .HasColumnType("datetime2");

                entity.Property(c => c.EndDate)
                .HasColumnType("datetime2");

                entity.Property(c => c.Price)
                .HasColumnType("decimal (18, 2)");

                //entity.HasMany(r => r.Resources)
                //.WithOne(c => c.Course)
                //.HasForeignKey(c => c.CourseId);

                //entity.HasMany(h => h.Homeworks)
                //.WithOne(c => c.Course)
                //.HasForeignKey(c => c.CourseId);

                //entity.HasMany(sc => sc.StudentsCourses)
                //.WithOne(c => c.Course)
                //.HasForeignKey(c => c.CourseId);
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasKey(r => r.ResourceId);

                entity.Property(r => r.Name)
                .HasMaxLength(50)
                .IsUnicode(true);

                entity.Property(r => r.Url)
                .IsUnicode(false);
            });

            modelBuilder.Entity<Homework>(entity =>
            {
                entity.HasKey(h => h.HomeworkId);

                entity.Property(h => h.SubmissionTime)
                .HasColumnType("datetime2");

                entity.Property(h => h.Content)
                .IsUnicode(false);
            });

            modelBuilder.Entity<StudentCourse>()
                .HasKey(k => new { k.StudentId, k.CourseId });
        }
    }
}