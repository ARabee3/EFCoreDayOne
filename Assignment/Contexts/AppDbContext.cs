using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
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

        // Composite Primary Key

        modelBuilder.Entity<Stud_Course>()
            .HasKey(c => new { c.Stud_Id, c.Course_Id });
        
        modelBuilder.Entity<Course_Inst>()
            .HasKey(c => new { c.Course_ID, c.Inst_ID});

        

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = Rabee3; Database = RouteEFCore1Assignment; Trusted_Connection = True; TrustServerCertificate = True;");
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }  
    public DbSet<Course_Inst> Course_Inst {  get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Stud_Course> Stud_Course { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Topic> Topics { get; set; }

}
