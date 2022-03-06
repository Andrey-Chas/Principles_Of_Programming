using System;
using static Lesson_02_Classes.MoblilePhone;

namespace Lesson_02_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            GSM gSM = new GSM();
            Console.WriteLine(gSM);

            Console.ReadKey();
        }
    }
}
