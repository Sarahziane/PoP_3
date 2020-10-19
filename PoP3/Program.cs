using System;

namespace PoP3
{
    class Program
    {
        static void Triangles()
        {

            Console.WriteLine("Side a of the triangle ? ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Side b of the triangle ? ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Side c of the triangle ? ");
            int c = Convert.ToInt32(Console.ReadLine());

            if(a==b || a ==c || c == b)
            {
                Console.WriteLine("Two of the sides are equal\n");
                if (a == b)
                    Console.WriteLine("Side a and side b are equal");
                if (b == c)
                    Console.WriteLine("Side b and side c are equal");
                if (c == a)
                    Console.WriteLine("Side c and side a are equal");

            }
            if (a.Equals(b) == true && a.Equals(c) == true)
            {
                Console.WriteLine("The 3 sides are equal");
                Console.WriteLine("Side a, side b and side c are equal");
            }
      
        }

        static void Numbers()
        {

        }

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n Task 1 : Triangles"

                                     + "\n\n Task 2 : Numbers"

                                     + "\n\n Please choose : ");
                int exo = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (exo)
                {
                    case 1:
                        Triangles();

                        break;

                    case 2:
                        Numbers();
                        break;

                    case 3:
                        break;
                }
                Console.WriteLine("\nPress any key to exit... ");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
