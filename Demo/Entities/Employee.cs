using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Entities;

// Entity
// POCO:
// Plain OLD CLR Object
// it is just a container for data (Have No Functionalities)

//internal class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public double Salary { get; set; }
//    public string Email { get; set; }
//    public DateTime DateofCreation { get; set; }
//}
//internal class Employee
//{
//    [Key]
//    [DatabaseGenerated(DatabaseGeneratedOption.None)]
//    public int EmpId { get; set; }

//    [Required]
//    [Column("EmpName",TypeName = "varchar")]
//    [MaxLength(50)]
//    [StringLength(50, MinimumLength =10)]
//    public string Name { get; set; }

//    [Range(20, 60)]
//    public int Age { get; set; }

//    [Column(TypeName = "money")]
//    [DataType(DataType.Currency)]
//    public double Salary { get; set; }

//    [EmailAddress]
//    public string Email { get; set; }

//    [Phone]
//    public string Phone { get; set; }

//    public DateTime DateofCreation { get; set; }
//}

public class Employee
{
    public string EmpId { get; set; }
    public string Name { get; set; }
    public int? Age { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }
    public DateTime DateOfCreation { get; set; }

}
