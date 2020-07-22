using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компараторы
{
    class Program
    {
        static void Main(string[] args)
        {

            Person[] mass = new Person[10];

            Random r = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = new Person(r.Next(1, 95), r.Next(30, 190), r.Next(20, 95));

                Console.WriteLine(mass[i].age+" "+ mass[i].height + " " + mass[i].weight);
            }

            Array.Sort(mass);

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < mass.Length; i++)
                Console.WriteLine(mass[i].age + " " + mass[i].height + " " + mass[i].weight);

            Array.Sort(mass, new HeightComparer());

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < mass.Length; i++)
                Console.WriteLine(mass[i].age + " " + mass[i].height + " " + mass[i].weight);




            Console.ReadKey();
        }
    }
}
