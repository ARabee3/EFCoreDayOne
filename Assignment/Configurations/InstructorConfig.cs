using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configurations;
internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        builder.HasKey(i => i.Id);

        builder.Property(i => i.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(i => i.Bonus)
            .IsRequired(false);

        builder.Property(i=> i.Salary)
            .IsRequired()
            .HasColumnType("money");

        builder.Property(i=> i.Address)
            .IsRequired();

        builder.HasOne(I => I.ManagedDepartment)
               .WithOne(D => D.Manager)
               .HasForeignKey<Department>(D => D.ManagerId)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(I => I.Dept)
            .WithMany(D => D.Instructors)
            .HasForeignKey(I => I.DeptId);

        

        


    }
}
