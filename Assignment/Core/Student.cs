using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    public class Student : Person
    {
        public Student[] students;
        private int placesInUse;
        public string StudentNumber;
        public int Age;
        public Address Address;
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int[] Scores;
        public float AverageScore
        {
            get
            {
                float total = 0;
                for (int i = 0; i < Scores.Length; i++)
                {
                    total = Scores[i] + total;
                }

                return total / Scores.Length;
            }
        }
        public string FullAddress 
        {
            get
            {
                return $"{Address.Street}, {Address.Country}, {Address.City}";
            }
        }

        public Student()
        {
            students = new Student[0];
            placesInUse = 0;
        }

        public void Add(Student student)
        {
            IncreaseArraySize();

            students[placesInUse] = student;
            placesInUse++;
        }

        public string NameAndAverageScore(int index)
        {
            return $"Student {students[index - 1].FullName} score is {Math.Round(students[index - 1].AverageScore, 2)}";
        }

        public string NameAndCity(int index)
        {
            return $"Student {students[index - 1].FullName} is living in {students[index - 1].Address.City}";
        }

        public string NameAndAddress(int index)
        {
            return $"Student {students[index - 1].FullName} address is {students[index - 1].FullAddress}";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendJoin(", ", Scores);
            return $"Name: {FullName}\nStudent number: {StudentNumber}\nAge: {Age}\nAddress: {FullAddress}\nScores: {sb}\nAverage score: {Math.Round(AverageScore, 2)}";
        }

        public void IncreaseArraySize()
        {
            if (placesInUse >= students.Length)
            {
                Student[] resizedArray = new Student[students.Length + 1];
                Array.Copy(students, 0, resizedArray, 0, students.Length);
                students = resizedArray;
            }
        }
    }
}
