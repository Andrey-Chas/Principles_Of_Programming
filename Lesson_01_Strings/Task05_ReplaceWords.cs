using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_01_Strings
{
    public static class Task05_ReplaceWords
    {
        public static void RunTheProgram()
        {
            string input = Input();

            string output = ReplaceWords(input);

            Output(output);

        }

        public static string Input()
        {
            return "Microsoft announced the next generation C# compiler today.\nIt uses advanced parses and special optimizer for the Microsoft CLR.";
        }

        public static string ReplaceWords(string someText)
        {
            string listOfWords = "C#, CLR, Microsoft";
            string[] listOfWordsAsArray = listOfWords.Split();

            char replaceSign = '*';

            char[] someTextAsChar = someText.ToCharArray();

            for (int i = 0; i < listOfWordsAsArray.Length; i++)
            {
                int indexOfWord = someText.IndexOf(listOfWordsAsArray[i].Trim(',', ' '));
                int length = listOfWordsAsArray[i].Trim(',', ' ').Length - 1;

                while (indexOfWord != -1)
                {
                    for (int j = indexOfWord; j <= indexOfWord + length; j++)
                    {
                        someTextAsChar[j] = replaceSign;
                    }

                    indexOfWord = someText.IndexOf(listOfWordsAsArray[i], indexOfWord + 1);
                }
            }

            string textWithReplacments = new string(someTextAsChar);

            return textWithReplacments;
        }

        public static void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
