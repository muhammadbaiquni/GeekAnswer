using System;

namespace SolveGeekSeat
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Lets save the villagers from the witch");
            Console.WriteLine("======================================");

            string input, isContinue;
            int age, year;

            Villager villagers = new Villager();

            try
            {
                do
                {
                    Console.Write("Age of Death: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out age);

                    Console.Write("Year of Death: ");
                    input = Console.ReadLine();
                    int.TryParse(input, out year);

                    if (age < 0 || year <= 0 || (year - age) <= 0)
                        return -1;

                    villagers.Add(age, year);

                    Console.Write("Continue input (Y/N)? ");
                    isContinue = Console.ReadLine();

                    Console.WriteLine();
                }
                while (isContinue.ToLower() == "y");

                villagers.Answer();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();

            return 0;
        }
    }
}
