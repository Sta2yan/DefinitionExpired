using System;
using System.Collections.Generic;
using System.Linq;

namespace DefinitionExpired
{
    class Progam
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Stew> stews = new List<Stew>();
            int countStew = 10;
            int maximumProductionYear = 2023;
            int minimumProductionYear = 2017;
            int yearNow = 2022;

            for (int i = 0; i < countStew; i++)
            {
                stews.Add(new Stew($"Тушенка_{i + 1}", random.Next(minimumProductionYear, maximumProductionYear)));
            }

            Console.WriteLine("Вся тушенка:");

            foreach (var stew in stews)
            {
                stew.ShowInfo();
            }

            Console.WriteLine("---------------------------------------------------");

            var filteredStews = stews.Where(stew => stew.ProductionYear + stew.ExpirationDate < yearNow);

            Console.WriteLine("Просроченная тушенка:");

            foreach (var stew in filteredStews)
            {
                stew.ShowInfo();
            }
        }
    }

    class Stew
    {
        public string Title { get; private set; }
        public int ProductionYear { get; private set; }
        public int ExpirationDate { get; private set; }

        public Stew(string title, int productionYear)
        {
            Title = title;
            ProductionYear = productionYear;
            ExpirationDate = 2;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Товар - {Title} | Год произовдства - {ProductionYear} | Срок годности - {ExpirationDate}");
        }
    }
}