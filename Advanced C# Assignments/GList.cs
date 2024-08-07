using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__Assignments
{
    public class GList<T>
    {
        private List<T> list = new List<T>();

        public void Add(T item)
        {
            list.Add(item);
        }

        public void Display()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
