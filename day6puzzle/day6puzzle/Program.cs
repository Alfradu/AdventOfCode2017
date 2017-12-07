using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day6puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"X:\Sysvet\adventOfCode\day6puzzle\input.txt");
            int[] instructions = text.Split(new char[] { '\t' }).Select(x => int.Parse(x)).ToArray();

            int[] answer = Pgm(instructions);
            Console.WriteLine(answer[0]);
            Console.WriteLine(answer[1]);

            Console.ReadKey();
        }

        private static int[] Pgm(int[] instructions)
        {
            int pickedValue;
            int index;
            List<int[]> recordedStates = new List<int[]>();

            while (!recordedStates.Any(x => x.SequenceEqual(instructions)))
            {
                recordedStates.Add(instructions.ToArray());
                pickedValue = instructions.Max();
                index = Array.IndexOf(instructions, pickedValue);
                instructions[index] = 0;
                for (int i = 1; i <= pickedValue; i++)
                {
                    instructions[(index+i) % instructions.Length]++;
                }

            }
            return new int[] {recordedStates.Count(), recordedStates.Count() - recordedStates.FindIndex(instructions.SequenceEqual)};  
        }
    }
}
