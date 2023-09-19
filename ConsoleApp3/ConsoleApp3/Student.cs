using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Student
    {
        public string full_name { get; set; }
        public int id { get; set; }
        public int s_course { get; set; }
        public Faculty s_faculty { get; set; }
        public string speciality { get; set; }
        public bool is_local_student { get; set; } = false;
        public List<string> subjects { get; set; } = new List<string>();
        public int semester { get; set; } = 1;

        public Student(string name, string surname, int student_id, int course, Faculty faculty, string speciality)
        {
            this.full_name = $"{name} {surname}";
            this.id = student_id;
            this.s_course = course;
            this.s_faculty = faculty;
            this.speciality = speciality;
        }

        public void AllInfo()
        {
            Console.WriteLine($"full Name: {full_name}");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"course: {s_course}");
            Console.WriteLine($"faculty: {s_faculty}");
            Console.WriteLine($"speciality: {speciality}");
            Console.WriteLine($"is local student: {is_local_student}");
            Console.WriteLine($"subjects: {string.Join(", ", subjects)}");
            Console.WriteLine($"semester: {semester}");
        }

        public void add_subject(string subject)
        {
            this.subjects.Add(subject);
        }

        public void transfer_to_next_semestr()
        {
            this.semester += 1;

            int nextCourse = (this.semester - 1 / 2) + 1;
            this.s_course = nextCourse;
            this.subjects.Clear();
        }
    }
}
