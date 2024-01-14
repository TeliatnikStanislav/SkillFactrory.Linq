using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
{
   1,
   "Сергей ",
   "Андрей ",
   300,
};
            var selectedobjects = (from p in objects where p is string orderby p select p);
            foreach (var o in selectedobjects)
            {
                Console.WriteLine(o.ToString());
            }

            foreach (var num in objects.Where(num => num is string).OrderBy(num => num))
            {
                Console.WriteLine(num);
            }

            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            foreach (var city in russianCities.Where(c => c.Name.Length <= 10).OrderBy(c => c.Name.Length))
            {
                Console.WriteLine($"{city.Name}");
            }
            Console.ReadKey();
        }

        public class City
        {
            public City(string name, long population)
            {
                Name = name;
                Population = population;
            }

            public string Name { get; set; }
            public long Population { get; set; }
        }
    }
}
