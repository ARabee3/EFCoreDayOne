using Assignment.Configurations;
using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Identity.Client;

namespace Assignment.Contexts;
internal class AppDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Department>()
            .HasKey(D => D.Id);

        modelBuilder.Entity<Department>().
            Property(d => d.Name)
            .IsRequired()
            .HasMaxLength(80);

        modelBuilder.Entity<Department>()
            .Property(d => d.HiringDate)
            .IsRequired(false)
            .HasDefaultValueSql("GETDATE()");

        modelBuilder.ApplyConfiguration(new InstructorConfig());
        modelBuilder.ApplyConfiguration(new TopicConfig());

        modelBuilder.Entity<Course_Inst>()
                    .HasKey(c => new { c.CourseId, c.InstructorId });

        modelBuilder.Entity<Stud_Course>()
                    .HasKey(c => new { c.CourseId, c.StudentId });

        //modelBuilder.Entity<Course_Inst>()
        //            .HasOne(c => c.Instructor)
        //            .WithMany(ci => ci.Courses)
        //            .HasForeignKey(ci => ci.InstructorId);
        
        //modelBuilder.Entity<Course_Inst>()
        //            .HasOne(c => c.Course)
        //            .WithMany(ci=> ci.Instructors)
        //            .HasForeignKey(ci => ci.CourseId);

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = Rabee3; Database = RouteEFCore2Assignment; Trusted_Connection = True; TrustServerCertificate = True;");
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }  
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Topic> Topics { get; set; }

}
