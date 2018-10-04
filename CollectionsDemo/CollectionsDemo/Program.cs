using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using CollectionsDemo.NonGeneric;
using CollectionsDemo.Generic;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            new SortedListDemo1().DemoSortedList();
            Console.ReadKey();
        }
    }

    class Employee
    {
        public string Name { get; set; }

        public int Id { get; set; }
    }
}
