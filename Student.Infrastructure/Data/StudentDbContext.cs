using Microsoft.EntityFrameworkCore;
using Student.Domain;


namespace Student.Infrastructure {
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {
        }

        public DbSet<StudentDetails> Students { get; set; }
        public DbSet<DepartmentDetails> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDetails>(entity =>
            {
                entity.ToTable("studentinformation");
                entity.HasKey(s => s.StudentId);
            });

            modelBuilder.Entity<DepartmentDetails>(entity =>
            {
                entity.ToTable("DepartmentDetails");
                entity.HasKey(d => d.DepartmentId);
            });

            modelBuilder.Entity<DepartmentDetails>()
                .HasMany(d => d.Student)
                .WithOne(s => s.Department)
                .HasForeignKey(s => s.DepartmentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}