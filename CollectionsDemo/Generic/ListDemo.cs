using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo.Generic
{
    class ListDemo
    {
        public void DemoList()
        {
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            //list.Add(10);

            list.ForEach(l => Console.WriteLine(l));

            list.Remove("");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            var arr = new int[] { 1, 2, 3, 4, 5 };

            var intList = arr.ToList();

            var toArr = intList.ToList();

            Console.WriteLine(list.Count);

            list.Clear();

            Console.WriteLine(list.Capacity);

        }
    }
}
