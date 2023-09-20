class Student:
    def __init__(self, name, surname, student_id, course, faculty, speciality):
        self.full_name = f"{name} {surname}"
        self.id = student_id
        self.s_course = course
        self.s_faculty = faculty
        self.speciality = speciality
        self.is_local_student = False
        self.subjects = []
        self.semester = 1

    def AllInfo(self):
        print(f"full name: {self.full_name}")
        print(f"id: {self.id}")
        print(f"course: {self.s_course}")
        print(f"faculty: {self.s_faculty.faculty_name}")
        print(f"speciality: {self.speciality}")
        print(f"is local student: {self.is_local_student}")
        print(f"subjects: {', '.join(self.subjects)}")
        print(f"semester: {self.semester}")

    def add_subject(self, subject):
        self.subjects.append(subject)

    def transfer_to_next_semester(self):
        self.semester += 1
        next_course = (self.semester - 1) // 2 + 1
        self.s_course = next_course
        self.subjects.clear()


class Faculty:
    def __init__(self, name, dean, cabinet_number):
        self.faculty_name = name
        self.dean = dean
        self.cabinet_number = cabinet_number
        self.students = []

    def add_student(self, student):
        self.students.append(student)
        student.s_faculty = self

    def withdraw_student(self, student_id):
        for student in self.students:
            if student.id == student_id:
                self.students.remove(student)
                student.s_faculty = None
                break


def main():
    faculty1 = Faculty("Math", "Mr. Arman", "Cabinet 99")
    faculty2 = Faculty("Computer Science", "Dr. Darkhan", "Cabinet 23")

    student1 = Student("Alan", "Tasbulatov", 115, 3, faculty1, "Big Data")
    student2 = Student("Bauyrzhan", "Sikhymbek", 251, 3, faculty1, "Oil Engineering")
    student3 = Student("Yu", "Alexandr", 390, 3, faculty2, "IT C#")

    faculty1.add_student(student1)
    faculty1.add_student(student2)
    faculty2.add_student(student3)

    # removed student with student_id = 251: Bauyrzhan Sikhymbek  
    faculty1.withdraw_student(251)

    print(f"students of {faculty1.faculty_name}:")
    for student in faculty1.students:
        student.AllInfo()

    print()

    print(f"students of {faculty2.faculty_name}:")
    for student in faculty2.students:
        student.AllInfo()


if __name__ == "__main__":
    main()
