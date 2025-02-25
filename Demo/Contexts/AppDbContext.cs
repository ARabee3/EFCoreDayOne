using Demo.Configurations;
using Demo.Entities;
using Microsoft.EntityFrameworkCore;
namespace Demo.Contexts;
internal class AppDbContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Fluent API
        ////modelBuilder.Entity<Employee>()
        ////    .HasKey("EmpId");

        ////modelBuilder.Entity<Employee>()
        ////    .HasKey(nameof(Employee.EmpId));

        //modelBuilder.Entity<Employee>()
        //    .HasKey(E => E.EmpId);

        //modelBuilder.Entity<Employee>()
        //    .Property(E => E.Name)
        //    .IsRequired()
        //    .HasColumnType("varchar")
        //    .HasMaxLength(50)
        //    .HasColumnName("EmployeeName");

        //modelBuilder.Entity<Employee>()
        //    .Property(E => E.Age)
        //    .IsRequired(false);

        //modelBuilder.Entity<Employee>()
        //    .Property(E => E.Salary)
        //    .HasColumnType("money");

        ////modelBuilder.Entity<Employee>()
        ////    .Property(E => E.DateOfCreation)
        ////    .HasDefaultValue(DateTime.Now);

        //// whenever inserting a row
        //modelBuilder.Entity<Employee>()
        //    .Property(E => E.DateOfCreation)
        //    .HasDefaultValueSql("GETDATE()");

        //modelBuilder.Entity<Employee>(
        //    E =>
        //    {
        //        E.HasKey(E => E.EmpId);

        //        E.Property(E => E.Name)
        //            .IsRequired()
        //            .HasColumnType("varchar")
        //            .HasMaxLength(50)
        //            .HasColumnName("EmployeeName");

        //        E.Property(E => E.Age)
        //            .IsRequired(false);

        //        E.Property(E => E.Salary)
        //            .HasColumnType("money");

        //        //modelBuilder.Entity<Employee>()
        //        //    .Property(E => E.DateOfCreation)
        //        //    .HasDefaultValue(DateTime.Now);

        //        // whenever inserting a row
        //        E.Property(E => E.DateOfCreation)
        //            .HasDefaultValueSql("GETDATE()");


        //    });

        #endregion
        modelBuilder.ApplyConfiguration(new EmployeeConfig());
        base.OnModelCreating(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = Rabee3; Database = RouteEFCore1; Trusted_Connection = True; TrustServerCertificate = True;");
    }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
}

