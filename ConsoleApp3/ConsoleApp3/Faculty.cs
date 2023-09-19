using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Faculty
    {
        public string faculty_name { get; set; }
        public string dean { get; set; }
        public string cabinet_number { get; set; }
        public List<Student> students { get; set; } = new List<Student>();

        public Faculty(string name, string dean, string cabinet_number)
        {
            this.faculty_name = name;
            this.dean = dean;
            this.cabinet_number = cabinet_number;
        }

        public void add_student(Student student)
        {
            this.students.Add(student);
            student.s_faculty = this;
        }

        public void withdraw_student(int student_id)
        {
            Student student_out = this.students.Find(student => student.id == student_id);

            if (student_out != null)
            {
                this.students.Remove(student_out);
                student_out.s_faculty = null;
            }
        }
    }
}
