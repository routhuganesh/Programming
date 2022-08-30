using System;
using System.Linq;

// new comment is added for git
public class Test
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
    public static void Main()
    {
        List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Ganesh",Department = "Developer"},
            new Student() { Id =2, Name = "Elon",Department = "Programmer"},
            new Student() {Id =3, Name = "Mark", Department = "Developer"}
        };
        var studentlist = students.Select(x=> new {x.Id, x.Name,x.Department}).ToList();
        int count = students.Sum(x => { if (x.Department == "Developer") return 2; else return 1; });
        Console.WriteLine(count);
        var studentList = students.ToList();
        bool check = students.Any(x => x.Department == "Developer");
        Console.WriteLine(check);
        foreach(var student in studentList)
        {
            Console.WriteLine(student); 
        }
        
    }
} 