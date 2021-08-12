using System;

namespace EX07SelectionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print
            Console.WriteLine();
            Console.WriteLine("Indtast vægten af dit brev ");
            Console.WriteLine();

            //Variabler
            double x = double.Parse(Console.ReadLine());
            

            if (x > 200)
            {
                //Print
                Console.WriteLine();
                Console.WriteLine($"{x}g = 30,00kr og derfor en pakke");
                Console.WriteLine();
                int y = 30;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5},00kr");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
            else if (x == 200)
            {
                Console.WriteLine();
                Console.WriteLine($"{x}g er = 20,00kr");
                Console.WriteLine();
                int y = 20;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
            else if (x >= 150)
            {
                //Print
                Console.WriteLine();
                Console.WriteLine($"{x}g er = 20,00kr");
                Console.WriteLine();
                int y = 20;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
            if (x == 150)
            {
                Console.WriteLine();
                Console.WriteLine($"{x}g er = 15,00kr");
                Console.WriteLine();
                int y = 15;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
            if (x >= 100)
            {
                //Print
                Console.WriteLine();
                Console.WriteLine($"{x}g er = 15,00kr");
                int y = 15;
                Console.WriteLine();
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
           if (x == 100)
            {
                Console.WriteLine();
                Console.WriteLine($"{x}g er = 10,00kr");
                Console.WriteLine();
                int y = 10;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
           if (x >= 50)
            {
                //Print
                Console.WriteLine();
                Console.WriteLine($"{x}g er = 10,00kr");
                Console.WriteLine();
                int y = 10;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
           if (x == 50)
            {
                Console.WriteLine();
                Console.WriteLine($"{x}g er = 7,00kr");
                Console.WriteLine();
                int y = 7;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
           if (x >= 20)
            {
                //Print
                Console.WriteLine();
                Console.WriteLine($"{x}g er = 7,00kr");
                Console.WriteLine();
                int y = 5;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
            }
           if (x < 20)
            {
                Console.WriteLine();
                Console.WriteLine($"{x}g = 5,00kr");
                Console.WriteLine();
                int y = 5;
                Console.Write("Skal pakken sendes ekspress? y & n: ");
                while (true)
                {
                    ConsoleKeyInfo cki;
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver sendt ekspress og prisen er nu: {y * 1.5}");
                        Console.ReadKey();
                    }
                    if (cki.Key == ConsoleKey.N)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Pakken bliver ikke sendt ekpress, så prisen er stadig {y},00kr");
                    }
                }
               
      
                
            }

            




            Console.ReadKey();
        }
    }
}
    
