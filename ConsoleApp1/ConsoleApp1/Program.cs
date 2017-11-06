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


            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the array elements[" + i + "]:");
                arr[i] = int.Parse(Console.ReadLine());
            }


            foreach (int value in arr)

            {
              
            }
            
            Array.Reverse(arr);

            


            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();

        }
    }
}






