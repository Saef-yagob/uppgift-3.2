using System;
namespace Uppgift_3._2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet? (ja/nej)");
            string gymnasiet = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            if (gymnasiet == "ja" && ålder < 22)
            {
                Console.WriteLine("Vi vill anställa dig nu");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Vi ska anställa en annan personal just nu.");
                Console.ReadKey();
            }
        }
    }
}

