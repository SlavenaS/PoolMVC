using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool.View
{
    class Display
    {
        public double Volume { get; set; }
        public double Pipe1Flow { get; set; }
        public double Pipe2Flow { get; set; }
        public double Hours { get; set; }
        public double TotalSumPipes_Percentage { get; set; }
        public double Pipe1_Percentage { get; set; }
        public double Pipe2_Percentage { get; set; }

        public void Input()
        {
            Console.Write("Enter the volume of the pool: ");
            Volume = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            Console.Write("Enter on pipe 1 flow rate: ");
            Pipe1Flow = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            Console.Write("Enter on pipe 2 flow rate: ");
            Pipe2Flow = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------------");
            Console.Write("Enter the number of hours the pipes have been running: ");
            Hours = double.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine($"The pool is: {Math.Round(TotalSumPipes_Percentage)}% full. Pipe 1: {Math.Round(Pipe1_Percentage)}%. Pipe 2: {Math.Round(Pipe2_Percentage)}%.");
            Console.WriteLine();
        }

    }
}

