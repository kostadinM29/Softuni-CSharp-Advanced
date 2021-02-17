using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassroomProject
{
    class Classroom
    {
        public Classroom(int capacity)
        {
            this.Capacity = capacity;
            students = new List<Student>();
        }

        private List<Student> students;

        public int Capacity { get; set; }

        public int Count => students.Count;

        // Method RegisterStudent(Student student) – adds an entity to the students if there is an empty seat for the student.
        // Returns "Added student {firstName} {lastName}" if the student is successfully added
        // Returns "No seats in the classroom" – if there are no more seats in the classroom
        public string RegisterStudent(Student student)
        {
            if (Count != Capacity)
            {
                students.Add(student);
                return $"Added student {student.FirstName} {student.LastName}"; // potential error
            }
            else
            {
                return "No seats in the classroom";
            }
        }
        // Method DismissStudent(string firstName, string lastName) – removes the student by the given names
        // Returns "Dismissed student {firstName} {lastName}" if the student is successfully dismissed
        // Returns "Student not found" if the student is not in the classroom
        public string DismissStudent(string firstName, string lastName)
        {
            Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            if (student == default)
            {
                return "Student not found";
            }
            else
            {
                students.Remove(student);
                return $"Dismissed student {student.FirstName} {student.LastName}"; // potential error
            }
        }
        //        •	Method GetSubjectInfo(string subject) – returns all the students with the given subject in the following format:
        //"Subject: {subjectName}
        //Students:
        //{firstName
        //    } {lastName
        //}
        //{firstName} {lastName}
        //…"
        //o Returns "No students enrolled for the subject" if the student is not in the classroom

        public string GetSubjectInfo(string subject)
        {
            StringBuilder sb = new StringBuilder();
            Student checker = students.FirstOrDefault(x => x.Subject == subject);
            sb.AppendLine($"Subject: {subject}");
            sb.AppendLine("Students:"); // potential error
            foreach (Student student in students)         // potential error
            {
                if (student.Subject == subject)
                {
                    sb.AppendLine($"{student.FirstName} {student.LastName}");
                }
            }
            if (checker == default)
            {
                return "No students enrolled for the subject";
            }
            else
            {
                return sb.ToString().Trim();
            }

        }
        //•	Method GetStudentsCount() – returns the count of the students in the classroom.
        public int GetStudentsCount()
        {
            return Count;   
        }
        //•	Method GetStudent(string firstName, string lastName) – returns the student with the given names.
        public Student GetStudent(string firstName, string lastName)
        {
            Student existingStudent = null;

            foreach (Student student in students)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    existingStudent = student;
                }
            }
            return existingStudent;
            //Student student = students.FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);
            //if (student == default)
            //{
            //    return null;
            //}
            //else
            //{
            //    return student.ToString();
            //}
        }
    }
}
