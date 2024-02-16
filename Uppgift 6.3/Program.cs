using System;
namespace uppgift6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Meny();
            int svar = int.Parse(Console.ReadLine());
            while (svar != 3)
            {
                switch (svar)
                {
                    case 1:
                        MenyvalAddera();
                        Console.ReadKey();
                        Console.Clear();
                        Meny();
                        svar = int.Parse(Console.ReadLine());
                        break;
                    case 2:
                        MenyvalStörstaTalet();
                        Console.ReadKey();
                        Console.Clear();
                        Meny();
                        svar = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        break;
                }
            }
        }
        static void Meny()
        {
            Console.WriteLine("1. Addera tre tal");
            Console.WriteLine("2. Största talet av två tal");
            Console.WriteLine("3. Avsluta programmet");
            Console.Write("Svar: ");
        }
        static void MenyvalAddera()
        {
            Console.WriteLine();
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2 = int.Parse(Console.ReadLine());
            Console.Write("Tal 3: ");
            int tal3 = int.Parse(Console.ReadLine());
            Console.WriteLine(Addera(tal1, tal2, tal3));
        }
        static void MenyvalStörstaTalet()
        {
            Console.Write("Tal 1: ");
            int tal1 = int.Parse(Console.ReadLine());
            Console.Write("Tal 2: ");
            int tal2= int.Parse(Console.ReadLine());
            Console.WriteLine(Störst(tal1, tal2));
        }
        static int Addera(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3;
        }
        static int Störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else if (tal2 > tal1)
            {
                return tal2;
            }
            else
            {
                return tal1+tal2;
            }
        }
    }
}