using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lesson_02_Classes.Person
{
    public class Student : Human, IComparable<Student>
    {
        private char mark { get; set; }

        public Student(string firstName, string lastName, char mark) : base(firstName, lastName)
        {
            this.mark = mark;
        }

        public int CompareTo(Student other)
        {
            return this.mark.CompareTo(other.mark);
        }

        public override string ToString()
        {
            return $"Name of the student: {firstName} {lastName}, Mark: {mark}";
        }
    }
}
