using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            //368078 
            int input = int.Parse(Console.ReadLine());
            double inputd = Math.Sqrt((double)input);
            int floor = (int)inputd+1;
            int goodSquare = floor * floor;
            int squareBelow = (floor - 2) * (floor - 2);
            int matrixStart = (goodSquare - squareBelow) / 2;
            int matrixLength = matrixStart / 2;

            int steps = 0;

            //is input closer to goodSquare or squareBelow
            if (input > matrixStart) 
            {
                //matrixStart < input < goodSquare
                if (input > goodSquare - matrixLength)
                {
                    //goodSquare-matrixLength < input < goodSquare, bottom line
                    steps = matrixLength - (goodSquare - input);
                }
                else
                {
                    //matrixStart < input < goodSquare-matrixLength, left column
                    steps = matrixLength - ((goodSquare - matrixLength) - input);
                }
            }
            else
            {
                if (input > matrixLength)
                {
                    //matriLength < input < matrixStart, top line
                    steps = matrixLength - (matrixStart - input);
                }
                else
                {
                    //squareBelow < input < matrixLength, right column
                    steps = matrixLength - input;
                }
            }

            if (steps < matrixLength)
            {
                steps = matrixLength - steps; 
            }
            Console.WriteLine(steps);

            Console.ReadKey();
        }

        private static void Pgm2()
        {
            int input = int.Parse(Console.ReadLine());
            int x=49;
            int y=49;
            int a = 0;
            int b = 0;
            int[] currentPos = { x , y };
            int[] previousPos = { x , y };
            int[,] n = new int[100, 100];
            n[x, y] = 1;
            while (n[x,y] < input)
            {
                //get next n and fill it out with a+b
                a = n[x, y];
                //try go left? if not change direction
                if (n[x,y] < 1)
            }
        }
    }
}
