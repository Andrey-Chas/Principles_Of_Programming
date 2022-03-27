using Lesson_02_Classes.Person;
using System;
using System.Collections.Generic;
using static Lesson_02_Classes.MoblilePhone;

namespace Lesson_02_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM gSM = new GSM();
            Console.WriteLine(gSM);


            // Person
            Console.WriteLine();

            Student st1 = new Student("Jack", "Jones", 'A');
            Student st2 = new Student("Sally", "Brown", 'A');
            Student st3 = new Student("John", "Smith", 'A');
            Student st4 = new Student("Julia", "Norman", 'C');
            Student st5 = new Student("Erik", "Holand", 'A');
            Student st6 = new Student("Mark", "Nolan", 'B');
            Student st7 = new Student("Polly", "Lolkly", 'B');
            Student st8 = new Student("Jay", "Oliver", 'C');
            Student st9 = new Student("Maria", "Blakly", 'A');
            Student st10 = new Student("Howard", "Silver", 'A');

            List<Student> listOfStudents = new List<Student>();

            listOfStudents.Add(st1);
            listOfStudents.Add(st2);
            listOfStudents.Add(st3);
            listOfStudents.Add(st4);
            listOfStudents.Add(st5);
            listOfStudents.Add(st6);
            listOfStudents.Add(st7);
            listOfStudents.Add(st8);
            listOfStudents.Add(st9);
            listOfStudents.Add(st10);

            listOfStudents.Sort();

            foreach (var st in listOfStudents)
            {
                Console.WriteLine(st);
            }

            Console.ReadKey();
        }
    }
}
