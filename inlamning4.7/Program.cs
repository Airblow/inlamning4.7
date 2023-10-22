using System;
using System.Net.WebSockets;

namespace inlamning4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett medelande som du vill ska skrivas vertikalt");
            string message = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Skriv in hur många steg åt höger du vill att medelandet ska skrivas ut");
            int jumps = int.Parse(Console.ReadLine());
            Console.WriteLine();


            for (int i = 0; i < message.Length; i++)
            {
                for(int j= 0; j < jumps; j++)
                {
                    Console.Write(" ");
                   
                }
                Console.WriteLine(message[i]);

            }
            
            Console.ReadKey();

        }

    }

}