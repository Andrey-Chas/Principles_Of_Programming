using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Lesson_01_Strings
{
    public static class Homework_EmailExtract
    {
        public static void RunTheProgram()
        {
            string input = Input();

            string extractedEmail = ExtractEmail(input);

            Output(extractedEmail, input);
        }

        private static string Input()
        {
            return "Please contact us by phone (+001 222 222 222) or by email\nat example@gmail.com or at test.user@yahoo.co.uk.";
        }

        private static string ExtractEmail(string input)
        {
            Regex patternForEmail = new Regex(@"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,6}", RegexOptions.IgnoreCase);

            StringBuilder sb = new StringBuilder();

            MatchCollection matches = patternForEmail.Matches(input);

            if (matches.Count > 0)
            {

                for (int i = 0; i < matches.Count; i++)
                {
                    sb.Append(matches[i] + " ");
                }

                return sb.ToString();
            }
            else
            {
                return null;
            }
        }

        private static void Output(string output, string input)
        {
            if (output != null)
            {
                string[] outputAsArray = output.Split();
                Console.WriteLine($"Email or emails extracted from the following text:{Environment.NewLine}\n{input}");
                Console.WriteLine(Environment.NewLine);
                for (int i = 0; i < outputAsArray.Length; i++)
                {
                    Console.WriteLine(outputAsArray[i]);
                }
            }

            else
            {
                Console.WriteLine($"There is no valid email to represent in the following extract:{Environment.NewLine}\n{input}");
            }
        }
    }
}
