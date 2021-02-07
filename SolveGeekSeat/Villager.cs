using System;
using System.Collections.Generic;
using System.Linq;

namespace SolveGeekSeat
{
    public class Villager
    {
        public int AgeOfDeath { get; set; }

        public int YearOfDeath { get; set; }

        public int NumberOfDeath { get; set; }

        public int Year { get; set; }

        public List<Villager> Villagers;

        public Villager()
        {
            Villagers = new List<Villager>();
        }

        public Villager(int ageOfDeath, int yearOfDeath, int year, int numberOfDeath)
        {
            AgeOfDeath = ageOfDeath;
            YearOfDeath = yearOfDeath;
            Year = year;
            NumberOfDeath = numberOfDeath;
        }

        public void Add(int ageOfDeath, int yearOfDeath)
        {
            int diff = yearOfDeath - ageOfDeath;
            int numberOfDeath = Fibonanci.Sum(diff);

            Villagers.Add(new Villager(ageOfDeath, yearOfDeath, diff, numberOfDeath));
        }

        public double Average()
        {
            return Villagers.Average(x => x.NumberOfDeath);
        }

        public void Answer()
        {
            int count = 0;

            foreach(var item in Villagers)
            {
                Console.WriteLine($"Person {count+1} born on Year = {item.YearOfDeath}-{item.AgeOfDeath} = {item.Year}, number of killed on year {item.Year} is {item.NumberOfDeath}");

                count++;
            }

            Console.WriteLine($"So, the average is {this.Average()}");
        }
    }
}
