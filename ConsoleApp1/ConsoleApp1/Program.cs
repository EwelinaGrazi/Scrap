﻿using System;
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
                Console.WriteLine(value);
            }
            Console.WriteLine();
            Array.Reverse(arr);

            foreach (int value in arr)
            {
                Console.WriteLine(value);
            }


            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadLine();

        }
    }
}






