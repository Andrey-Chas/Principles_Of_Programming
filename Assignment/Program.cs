using System;
using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student array = new Student();

            int numberOfStudents = 0;

            while (true)
            {
                DisplayCoverPage(numberOfStudents);

                string userInput = Console.ReadLine();

                while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5" && userInput != "0")
                {
                    Console.Write("This option does not exist. Please type an exsisting one: ");
                    userInput = Console.ReadLine();
                }

                if (userInput == "1")
                {
                    Console.Clear();
                    AddStudent(array);
                    numberOfStudents++;
                }

                if (userInput == "2")
                {
                    Console.Clear();
                    if (array.students.Length != 0)
                    {
                        NameAndAverageScore(array);
                    }
                    else
                    {
                        Console.WriteLine("The list is empty!");
                        PressKeyToContinue();
                    }
                }

                if (userInput == "3")
                {
                    Console.Clear();
                    if (array.students.Length != 0)
                    {
                        NameAndCity(array);
                    }
                    else
                    {
                        Console.WriteLine("The list is empty!");
                        PressKeyToContinue();
                    }
                }

                if (userInput == "4")
                {
                    Console.Clear();
                    if (array.students.Length != 0)
                    {
                        NameAndAddress(array);
                    }
                    else
                    {
                        Console.WriteLine("The list is empty!");
                        PressKeyToContinue();
                    }
                }

                if (userInput == "5")
                {
                    Console.Clear();
                    if (array.students.Length != 0)
                    {
                        DetailedInformationAboutStudent(array);
                    }
                    else
                    {
                        Console.WriteLine("The list is empty!");
                        PressKeyToContinue();
                    }
                }

                if (userInput == "0")
                {
                    break;
                }
            }
        }

        private static void DisplayCoverPage(int numberOfStudents)
        {
            Console.Clear();
            Console.WriteLine("INFORMATION ABOUT STUDENT");
            Console.WriteLine($"\n\tCurrently in the list {numberOfStudents} student(s)");
            Console.WriteLine("\n\t1. Add student");
            Console.WriteLine("\n\t2. Display name and average score of the student");
            Console.WriteLine("\n\t3. Display name and city of the student");
            Console.WriteLine("\n\t4. Display name and address of the student");
            Console.WriteLine("\n\t5. Display detailed information about the student");
            Console.WriteLine("\n\t0. Exit");
            Console.Write("\nPlease enter your choice by typing one number (0 - 5): ");
        }

        private static void AddStudent(Student array)
        {
            int num;

            Console.WriteLine("ADD STUDENT");
            Console.WriteLine();
            Console.Write("Please type first name of the student: ");
            var firstName = Console.ReadLine();

            Console.Write("Please type last name of the student: ");
            var lastName = Console.ReadLine();

            Console.Write("Please type student number: ");
            var studentNumber = Console.ReadLine();

            Console.Write("Please type age of the student: ");
            var age = Console.ReadLine();
            while (!int.TryParse(age, out num) || Convert.ToInt32(age) < 0)
            {
                Console.Write("This is not a number or it is less than 0.\nPlease type a number and greater than 0: ");
                age = Console.ReadLine();
            }

            int ageConverted = Convert.ToInt32(age);

            Console.Write("Please type street: ");
            var street = Console.ReadLine();

            Console.Write("Please type city: ");
            var city = Console.ReadLine();

            Console.Write("Please type country: ");
            var country = Console.ReadLine();

            Console.Write("Please enter score of the student (type of number is integer between 3 - 6): ");
            var score = Console.ReadLine();
            while (!int.TryParse(score, out num) || score == "" || Convert.ToInt32(score) < 3 || Convert.ToInt32(score) > 6)
            {
                Console.Write("Student must have at least one score and has to be a number.\nPlease type a number (type of number is integer between 3 - 6): ");
                score = Console.ReadLine();
            }
            int scoreConverted = Convert.ToInt32(score);
            List<int> scores = new List<int>();

            while (true)
            {
                while (!int.TryParse(score, out num) || Convert.ToInt32(score) < 3 || Convert.ToInt32(score) > 6)
                {
                    Console.Write("This is not a number or it is in incorrect format.\nPlease type a number (type of number is integer between 3 - 6)\nor leave a blank line to exit: ");
                    score = Console.ReadLine();
                    if (score == "")
                    {
                        break;
                    }
                }
                if (score == "")
                {
                    break;
                }
                Console.Write("Keep typing scores (type of number is integer between 3 - 6)\nor leave a blank line to exit: ");
                scoreConverted = Convert.ToInt32(score);
                scores.Add(scoreConverted);
                score = Console.ReadLine();
                if (score == "")
                {
                    break;
                }
            }

            Address address = new Address
            {
                Street = street,
                City = city,
                Country = country
            };


            Student student = new Student
            {
                FirstName = firstName,
                LastName = lastName,
                StudentNumber = studentNumber,
                Age = ageConverted,
                Address = address,
                Scores = scores.ToArray()
            };

            array.Add(student);

            Console.WriteLine();
            Console.WriteLine("The student has been saved!");
            PressKeyToContinue();
        }

        private static void NameAndAverageScore(Student array)
        {
            while (true)
            {
                Console.WriteLine("DISPLAY STUDENT NAME AND AVERAGE SCORE");
                Console.WriteLine();

                int index = AskForIndex(array);
                if (Convert.ToString(index) == "0")
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine(array.NameAndAverageScore(index));

                while (true)
                {
                    index = AskForAnotherIndex(array);
                    if (Convert.ToString(index) == "0")
                    {
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine(array.NameAndAverageScore(index));
                }
                if (Convert.ToString(index) == "0")
                {
                    break;
                }
            }
        }

        private static void NameAndCity(Student array)
        {
            while (true)
            {
                Console.WriteLine("DISPLAY STUDENT NAME AND CITY");
                Console.WriteLine();

                int index = AskForIndex(array);
                if (Convert.ToString(index) == "0")
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine(array.NameAndCity(index));

                while (true)
                {
                    index = AskForAnotherIndex(array);
                    if (Convert.ToString(index) == "0")
                    {
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine(array.NameAndCity(index));
                }
                if (Convert.ToString(index) == "0")
                {
                    break;
                }
            }
        }

        private static void NameAndAddress(Student array)
        {
            while (true)
            {
                Console.WriteLine("DISPLAY STUDENT NAME AND ADDRESS");
                Console.WriteLine();

                int index = AskForIndex(array);
                if (Convert.ToString(index) == "0")
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine(array.NameAndAddress(index));

                while (true)
                {
                    index = AskForAnotherIndex(array);
                    if (Convert.ToString(index) == "0")
                    {
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine(array.NameAndAddress(index));
                }
                if (Convert.ToString(index) == "0")
                {
                    break;
                }
            }
        }

        private static void DetailedInformationAboutStudent(Student array)
        {
            while (true)
            {
                Console.WriteLine("DISPLAY DETAILED INFORMATION ABOUT STUDENT");
                Console.WriteLine();

                int index = AskForIndex(array);
                if (Convert.ToString(index) == "0")
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine(array.students[index - 1]);

                while (true)
                {
                    index = AskForAnotherIndex(array);
                    if (Convert.ToString(index) == "0")
                    {
                        break;
                    }

                    Console.WriteLine();
                    Console.WriteLine(array.students[index - 1]);
                }
                if (Convert.ToString(index) == "0")
                {
                    break;
                }
            }
        }

        private static int AskForIndex(Student array)
        {
            int num;

            Console.Write("Please type an index of the student you would like to display\nor type 0 to exit: ");
            var index = Console.ReadLine();
            while (!int.TryParse(index, out num) || Convert.ToInt32(index) < 0 || Convert.ToInt32(index) > array.students.Length)
            {
                Console.Write("This is not a number or it is outside the range.\nPlease type a number and within range or type 0 to exit: ");
                index = Console.ReadLine();
                if (index == "0")
                {
                    return 0;
                }
            }
            int indexConverted = Convert.ToInt32(index);

            return indexConverted;
        }

        private static int AskForAnotherIndex(Student array)
        {
            int num;

            Console.Write("If you would like to continue display students type an\nindex you would like to display\nor type 0 to exit: ");
            var index = Console.ReadLine();
            while (!int.TryParse(index, out num) || Convert.ToInt32(index) < 0 || Convert.ToInt32(index) > array.students.Length)
            {
                Console.Write("This is not a number or it is outside the range.\nPlease type a number and within range or type 0 to exit: ");
                index = Console.ReadLine();
                if (index == "0")
                {
                    return 0;
                }
            }
            int indexConverted = Convert.ToInt32(index);

            return indexConverted;
        }

        private static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
