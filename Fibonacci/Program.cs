using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int b = 1;
            int c = 0;
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ingrese un numero");
            int a = Int32.Parse(Console.ReadLine());
            

            for (int i= 1; i <= a; i++)
            {
               int d = c;
                c = b;
                b = d + c;
                Console.WriteLine(b);
            }

            Console.ReadKey();
        }
    }
}
