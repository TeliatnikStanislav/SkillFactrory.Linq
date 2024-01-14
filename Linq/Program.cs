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
            Console.ReadKey();
        }
    }
}
