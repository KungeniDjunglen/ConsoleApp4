using System;

namespace Space
{
    class Program
    {
        static int GetNumberFromUser()
        {
            Console.Write("Skriv ett tal ? ");
            int Number = int.Parse(Console.ReadLine());
            return Number;
        }
        static void Main()
        {
            Console.WriteLine("Välkommen till miniräknaren");
            Console.WriteLine("1. Addera");
            Console.WriteLine("2. Subtraktera");
            int val = int.Parse(Console.ReadLine());
            switch (val)
            {
                case 1:
                    Class1 tal = new Class1();

                    tal.tal1 = GetNumberFromUser();
                    tal.tal2 = GetNumberFromUser();
                    Console.WriteLine("Talet är: " + tal.Addera(tal.tal1, tal.tal2));
                    break;
                case 2:
                    Class2 minusTal = new Class2();

                    minusTal.tal1 = GetNumberFromUser();
                    minusTal.tal2 = GetNumberFromUser();
                    Console.WriteLine("Talet är: " + minusTal.Minus(minusTal.tal1, minusTal.tal2));
                    break;
            }


        }
    }

}