using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day1puzzle1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            string text = System.IO.File.ReadAllText(@"X:\Sysvet\adventOfCode\input.txt");

            Console.WriteLine(p.Prg1(text));
            Console.WriteLine(p.Prg2(text));
            Console.ReadKey();
        }
        public int Prg1(string text)
        {
            int count = 0, current, next;

            for (int i = 0; i < text.Length; i++)
            {
                current = i;
                if (i == text.Length - 1)
                {
                    next = 0;
                }
                else
                {
                    next = i + 1;
                }

                if (text.Substring(current, 1) == text.Substring(next, 1))
                {
                    count = count + Int32.Parse(text.Substring(i, 1).ToString());

                }
            }
            return count;
        }

        public int Prg2(string text)
        {
            int count = 0, current, next;

            for (int i = 0; i < text.Length; i++)
            {
                current = i;
                if (current < text.Length/2)
                {
                    next = current + text.Length/2;
                }
                else
                {
                    next = current + text.Length/2 - text.Length;
                }

                if (text.Substring(current, 1) == text.Substring(next, 1))
                {
                    count = count + Int32.Parse(text.Substring(i, 1).ToString());
                }
            }
            return count;
        }
    }
}
