using System;
using System.Data;
using System.Linq;


//force push
public class Test
{
    //public class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Department { get; set; }
    //}
    public static void Main()
    {
        //List<Student> students = new List<Student>()
        //{
        //    new Student() { Id = 1, Name = "Ganesh",Department = "Developer"},
        //    new Student() { Id =2, Name = "Elon",Department = "Programmer"},
        //    new Student() {Id =3, Name = "Mark", Department = "Developer"}
        //};
        //var studentlist = students.Select(x=> new {x.Id, x.Name,x.Department}).ToList();
        //int count = students.Sum(x => { if (x.Department == "Developer") return 2; else return 1; });
        //Console.WriteLine(count);
        //var studentList = students.ToList();
        //bool check = students.Any(x => x.Department == "Developer");
        //Console.WriteLine(check);
        //foreach(var student in studentList)
        //{
        //    Console.Write(student); 
        //}
        //DataTable d = new DataTable();
        //d.Columns.Add("ID", typeof(int));
        //d.Columns.Add("Name", typeof(string));
        //d.Rows.Add(1, "Ganesh");
        //d.Rows.Add(2, "Ashik");
        //d.Rows.Add(3, "Akhilesh");
        //DataRowCollection row = d.Rows;
        //for (int i = 0; i < row.Count; i++)
        //{
        //    Console.WriteLine(row[i][1].ToString());
        //}
        // for excel sheet
        DataTable d = new DataTable();
        d.Columns.Add("Id", typeof(int));
        d.Columns.Add("Name", typeof(string));
        d.Rows.Add(1, "Ganesh");
        d.Rows.Add(2, "Virat");
        DataRowCollection row = d.Rows;
        for (int i=0;i<row.Count; i++)
        {
            Console.WriteLine(row[i][1].ToString());
        }
    }
} 