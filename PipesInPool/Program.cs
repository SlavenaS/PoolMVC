using PipesInPool.Controlles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PoolController myController = new PoolController();

            }
            catch(ArgumentOutOfRangeException ) 
            {
                Console.WriteLine("You must enter a number bigger than 0");
            }
            catch(FormatException )
            {
                Console.WriteLine("You must enter a number");
            }
            catch (ArgumentException ) 
            {
                Console.WriteLine("Method is not valid");
            }

        }
    }
}
