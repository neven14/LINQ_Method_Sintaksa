using System;
using System.Linq;
using System.Collections.Generic;
public class LinQMethod
{
	public static void Main()
	{
		// Student collection
		List<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John" } ,
				new Student() { StudentID = 2, StudentName = "Moin" } ,
				new Student() { StudentID = 3, StudentName = "Bill" } ,
				new Student() { StudentID = 4, StudentName = "Ram" } ,
				new Student() { StudentID = 5, StudentName = "Ron"  }
			};


		var result = studentList.Select(s => s.StudentName).Where(s => s.Contains("B"));



		foreach (var str in result)
		{
			Console.WriteLine(str);
		}
		Console.ReadKey();
	}
}


public class Student
{
	public int StudentID { get; set; }
	public string StudentName { get; set; }
}
