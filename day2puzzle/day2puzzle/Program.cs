using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"X:\Sysvet\adventOfCode\day2puzzle\input.txt");
            string[] textLine = text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(Prg1(textLine));
            Console.WriteLine(Prg2(textLine));

            Console.ReadKey();
        }

        private static int Prg1(string[] textLine)
        {
            int sum = 0;
            for (int i = 0; i < textLine.Length; i++)
            {
                string[] stringNumbers = textLine[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);
                var numbers = stringNumbers.Select(x => int.Parse(x));
                //Learned that enums are cool
                sum += numbers.Max() - numbers.Min();
            }
            return sum;
        }

        private static int Prg2(string[] textLine)
        {
            int sum = 0;
            for (int i = 0; i < textLine.Length; i++)
            {
                string[] stringNumbers = textLine[i].Split(new string[] { "\t" }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = stringNumbers.Length-1; j > -1; j--)
                {
                    for (int k = 0; k < stringNumbers.Length; k++)
                    {
                        if (int.Parse(stringNumbers[k]) % int.Parse(stringNumbers[j]) == 0 && k != j)
                        {
                            sum += int.Parse(stringNumbers[k]) / int.Parse(stringNumbers[j]);
                        }
                    }
                }
            }
            return sum;
        }
    }
}
