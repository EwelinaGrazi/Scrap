using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)



        {

            int[] array = {1, 2, 3 };
         
            foreach (int value in array)
            { Console.WriteLine(value);
            }
            Console.WriteLine();
            Array.Reverse(array);
            foreach (int value in array)
            { Console.WriteLine(value);
            }
            Console.WriteLine();
        }
    }
}
                

             

               

