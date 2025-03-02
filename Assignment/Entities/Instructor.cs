namespace Assignment.Entities;
internal class Instructor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int? Bonus { get; set; }
    public int Salary { get; set; }
    public string Address { get; set; }
    public int HourRate { get; set; }

    public int DeptId { get; set; }
    public Department Dept { get; set; }
    
    public Department ManagedDepartment { get; set; }
    public List<Course_Inst> Courses { get; set; }

}
