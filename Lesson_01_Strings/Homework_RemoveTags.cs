using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    public static class Homework_RemoveTags
    {
        public static void RunTheProgram()
        {
            string input = Input();

            string removedTags = RemoveTags(input);

            Output(removedTags);
        }

        private static string Input()
        {
            return "<html>\n<head><title>News</title></head>\n<body><p><a href=\"http://vum.com\">VUM</a>aims to provide free real-world practical training for young people who want to turn into skillful software engineers.</p></body></html>";
        }

        private static string RemoveTags(string input)
        {
            StringBuilder sb = new StringBuilder();

            char[] textAsCharArray = input.ToCharArray();

            int indexOfTheOpeningTag = input.IndexOf("<", 1);
            int indexOfTheClosingTag = input.IndexOf(">");
            int length;

            //while (indexOfTheClosingTag != -1)
            //{
            //    length = indexOfTheClosingTag + 1 - indexOfTheOpeningTag;
            //    input = input.Remove(indexOfTheOpeningTag, length);
            //    indexOfTheOpeningTag = input.IndexOf("<");
            //    indexOfTheClosingTag = input.IndexOf(">");
            //}

            while (indexOfTheOpeningTag != -1)
            {
                length = indexOfTheOpeningTag - 1 - indexOfTheClosingTag;
                string substring = input.Substring(indexOfTheClosingTag + 1, length);
                if (length != 0)
                {
                    sb.Append(substring + " ");
                }
                indexOfTheOpeningTag = input.IndexOf("<", indexOfTheOpeningTag + 1);
                indexOfTheClosingTag = input.IndexOf(">", indexOfTheClosingTag + 1);
            }

            return sb.ToString();
        }

        private static void Output(string output)
        {
            Console.WriteLine(output.Trim());
        }
    }
}
