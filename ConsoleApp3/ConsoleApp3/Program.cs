using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty faculty1 = new Faculty("Math", "Mr. Arman", "Cabinet 99");
            Faculty faculty2 = new Faculty("Computer Science", "Dr. Darkhan", "Cabinet 23");

            Student student1 = new Student("Sultan", "Sultanov", 115, 2, faculty1, "Oil Engineering");
            Student student2 = new Student("Omarov", "Omarov", 251, 2, faculty1, "Oil Engineering");
            Student student3 = new Student("Ermek", "Ermekov", 390, 3, faculty2, "IT C#");

            faculty1.add_student(student1);
            faculty1.add_student(student2);
            faculty2.add_student(student3);

            // removed student with student_id = 251: Omar Omarov  
            faculty1.withdraw_student(251);

            Console.WriteLine($"students of {faculty1.faculty_name}:");
            foreach (var student in faculty1.students)
            {
                student.AllInfo();
            }

            Console.WriteLine();
            Console.WriteLine($"students of {faculty2.faculty_name}:");
            foreach (var student in faculty2.students)
            {
                student.AllInfo();
            }
        }
    }
}
