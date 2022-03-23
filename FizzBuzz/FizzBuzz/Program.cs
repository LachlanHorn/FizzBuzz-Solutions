using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            string write;
            

            Console.WriteLine("Enter limit");
            n = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x <= n; x++)
            {
                if (x % 3 == 0 && x % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                }
                else if(x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(x);
                }
                
            }
        }

        static void method2(int n)
        {
            string write;
            for (int x = 0; x <= n; x++)
            {
                string fizz = "";
                string buzz = "";

                write = Convert.ToString(x);

                if ((x % 3 == 0))
                {
                    fizz = "Fizz";
                    write = Convert.ToString(fizz + buzz);
                }
                if ((x % 5 == 0))
                {
                    buzz = "Buzz";
                    write = Convert.ToString(fizz + buzz);
                }

                Console.WriteLine(write);


            }
        }

    }
}
