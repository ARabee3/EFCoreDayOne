using Assignment.Contexts;
using Assignment.Entities;

namespace Assignment;

internal class Program
{
    static void Main(string[] args)
    {
        using AppDbContext context = new();
        //Department d = new Department
        //{
        //    Name = "Dept1",
        //    HiringDate = DateTime.Now,

        //};
        //context.Add(d);

        //Instructor i = new Instructor
        //{
        //    Name = "Ahmed Rabie",
        //    Bonus = 100,
        //    Salary = 12000,
        //    Address = "Minya",
        //    HourRate = 1000,
        //    DeptId = 2
        //};
        //context.Add(i);

        // Update
        //var dept = context.Departments.FirstOrDefault(d => d.Id == 2);
        //dept.ManagerId = 1;

        Topic t = new Topic
        {
            Name = "Topic 1"
        };
        //context.Add(t);
        Course c = new Course
        {
            Name = "Course 1",
            Duration = 10,
            Description = "Test Test Test",
            TopicId = 2
        };
        //context.Add(c);
        Student s = new Student
        {
            FName = "Mohamed",
            LName = "Magdy",
            Address = "Minya",
            Age = 21,
            DepartmentId = 2
        };
        // context.Add(s);



        //Stud_Course sc = new Stud_Course
        //{
        //    StudentId = 2,
        //    CourseId = 3,
        //    Grade = "A"
        //};
        //context.Add(sc);


        //Course_Inst ci = new Course_Inst
        //{
        //    CourseId = 3,
        //    InstructorId = 1,
        //    Evaluate = "Evaluation"
        //};

        //context.Add(ci);
        //Topic t2 = new Topic
        //{
        //    Name = "Topic 2"
        //};

        //context.Add(t2);

        // Delete 
        //var topic = context.Topics.FirstOrDefault(i => i.Id == 3);
        //context.Remove(topic);

        // Read
        //var inst = context.Instructors.FirstOrDefault(i => i.Id == 1);
        //Console.WriteLine(inst?.Name);
       // context.SaveChanges();


    }
}
