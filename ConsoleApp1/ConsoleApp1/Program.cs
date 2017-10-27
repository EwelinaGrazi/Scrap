using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Variable
    {

        static void Main(string[] args)

        {


            Console.WriteLine("What is your name?");
            Console.Write("type your first name ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("type your last name ");

            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + "" + myLastName);
            Console.ReadLine();



        }
    }
}
                
                

