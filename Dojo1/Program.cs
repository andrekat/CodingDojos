using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dojo1.Custom;

namespace Dojo1
{
    class Program
    {
        static void Main(string[] args)
        {

            var intStack = new DojoStack<int>(10);

            try
            {
                intStack.Push(20);
                intStack.Push(30);
                intStack.Push(40);
                intStack.Push(50);
                intStack.Push(60);

            
                Console.WriteLine(intStack.Peek());
                intStack.Push(30);

                Console.WriteLine(intStack.Peek());

                Console.WriteLine(intStack.Pop());

                Console.WriteLine(intStack.Pop());

                Console.WriteLine(intStack.Pop());

                Console.WriteLine(intStack.Pop());

                Console.WriteLine(intStack.Pop());

                Console.WriteLine(intStack.Pop());

                Console.WriteLine(intStack.Pop());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured: " + ex.Message);
            }


            Console.Read();


        }
    }
}
