using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"X:\Sysvet\adventOfCode\day5puzzle\input.txt");
            int[] instructions = text.Split(new char[] { '\n' }).Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(Pgm(instructions,0));
            instructions = text.Split(new char[] { '\n' }).Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(Pgm(instructions,1));
            Console.ReadKey();
        }
        private static int Pgm(int[] instructions,int part2)
        {
            int location = 0;
            int prevLocation;
            int jumps = 0;
            int i;
            while (location < instructions.Length)
            {
                prevLocation = location;
                i = instructions[location] >= 3 ? -2 : 0;
                location = location + instructions[location];
                instructions[prevLocation] += 1+i*part2;
                jumps++;
            }
            return jumps;
        }
    }
}
