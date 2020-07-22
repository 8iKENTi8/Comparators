using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компараторы
{
    class HeightComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x.weight < y.weight)
                return -1;
            else if (x.weight > y.weight)
                return 1;
            else return 0;
        }
    }
}
