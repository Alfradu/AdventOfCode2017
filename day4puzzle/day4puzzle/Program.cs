using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"X:\Sysvet\adventOfCode\day4puzzle\input.txt");
            string[] textLine = text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(Pgm(textLine));
            Console.ReadKey();
        }
        private static int Pgm(string[] textLine)
        {
            int count = 0;
            string currentWord;
            bool dupe = false;

            for (int i = 0; i < textLine.Length; i++)
            {
                string[] wordList = textLine[i].Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int l = 0; l < wordList.Length; l++)
                {
                    //Prg2 anagram checker. Rest does the same as pgm1.
                    /*for (int j = 0; j < wordList.Length; j++)
                    {
                        char[] charWord = wordList[j].ToCharArray();
                        Array.Sort(charWord);
                        wordList[j] = new string(charWord);
                    }*/
                    currentWord = wordList[l];
                    for (int k = 0; k < wordList.Length; k++)
                    {
                        if (currentWord == wordList[k] && l != k)
                        {
                            dupe = true;
                        }
                    }
                }
                if (!dupe)
                {
                    count++;
                }
                else
                {
                    dupe = false;
                }
            }
            return count;
        }
    }
}

