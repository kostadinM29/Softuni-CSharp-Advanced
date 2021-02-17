using System;
using System.Collections.Generic;
using System.Text;

namespace ClassroomProject
{
    class Student
    {
        public Student(string firstname, string lastname, string subject)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Subject = subject;

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public override string ToString()
        {
            return $"Student: First Name = {FirstName}, Last Name = {LastName}, Subject = {Subject}";

        }
    }
}
