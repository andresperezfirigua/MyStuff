using System;

namespace C_Sharp_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 1;

            /*f (a == b)
            {
                Console.WriteLine("Hello World!");
            }else
            {
                Console.WriteLine("It´s not the same");
            }*/

            for (int i = 0; i < 10; i++)
            {
                a = a + b;
                Console.WriteLine(a);
            }
            
    }
    }
} 
