using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    public static class Task06_ParseURL
    {
        public static void RunTheProgram()
        {
            // Parses URL in the following format [protocol]://[server]/[resource]

            string inputURL = Input();

            string[] output = ParseURL(inputURL);

            Output(output);
        }

        public static string Input()
        {
            return "http://www.cnn.com/video";
        }

        public static string[] ParseURL(string validURL)
        {
            string[] parseArray = new string[3];
            int indexOfColon = validURL.IndexOf(":");
            int indexOfThirdSlash = validURL.IndexOf("/", indexOfColon + 3);
            int lenthTillThirdSlash = indexOfThirdSlash - indexOfColon;

            parseArray[0] = validURL.Substring(0, indexOfColon);
            parseArray[1] = validURL.Substring(indexOfColon + 3, lenthTillThirdSlash - 3);
            parseArray[2] = validURL.Substring(indexOfThirdSlash);

            return parseArray;
        }

        public static void Output(string[] output)
        {
            Console.WriteLine($"[protocol]=\"{output[0]}\"");
            Console.WriteLine($"[server]=\"{output[1]}\"");
            Console.WriteLine($"[resource]=\"{output[2]}\"");
        }
    }
}
