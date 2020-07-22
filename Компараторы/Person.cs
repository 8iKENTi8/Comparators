using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компараторы
{
    class Person : IComparable
    {
        Person()
        {

        }

        public Person(int age, int height, int weight)
        {
            this.age = age;
            this.weight = weight;
            this.height = height;
        }



        public int age, weight, height;


        public int CompareTo(object obj)
        {
            Person p = obj as Person;

            if (p != null)
                if (this.age < p.age)
                    return -1;
                else if (this.age == p.age)
                    return 0;
                else
                    return 1;
            else
                throw new Exception("Параметр должен быть типа Person");


        }
    }
}
