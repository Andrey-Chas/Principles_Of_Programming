using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_02_Classes.Person
{
    public class Worker : Human
    {
        private decimal wage { get; set; }
        private int hoursWorked { get; set; }

        public Worker(string firstName, string lastName, decimal wage, int hoursWorked) : base(firstName, lastName)
        {
            this.wage = wage;
            this.hoursWorked = hoursWorked;

            decimal payRate = CalculateHourlyWage(wage, hoursWorked);

            Console.WriteLine(Math.Round(payRate, 2));
        }

        private decimal CalculateHourlyWage(decimal wage, int hoursWorked)
        {
            decimal payRate;

            decimal hoursWorkedDecimal = Convert.ToDecimal(hoursWorked);

            payRate = wage / hoursWorkedDecimal;

            return payRate;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}, {wage}, {hoursWorked}";
        }
    }
}
