using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo.Generic
{
    class DictionaryDemo
    {
        public void DemoDictionary()
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("A", "Apple");
            dict.Add("B", "Ball");
            dict.Add("C", "Cat");

            dict.Remove("C");

            if (dict.ContainsKey("A"))
            {
                var value = dict["A"];
                Console.WriteLine(value);
            }

            string test;
            if (dict.TryGetValue("B", out test)) // Returns true.
            {
                Console.WriteLine(test); // This is the value at cat.
            }
            if (dict.TryGetValue("D", out test)) // Returns false.
            {
                Console.WriteLine(false); // Not reached.
            }

            dict["A"] = "Ant";
        }
    }
}
