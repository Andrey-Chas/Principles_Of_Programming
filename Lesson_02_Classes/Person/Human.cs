using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_02_Classes.Person
{
    public class Human
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
