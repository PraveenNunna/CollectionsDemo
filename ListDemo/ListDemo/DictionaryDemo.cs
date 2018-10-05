using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class DictionaryDemo
    {
        public void DemoDictionary()
        {
            Dictionary<int, string> equipmentDictionary = new Dictionary<int, string>();
            equipmentDictionary.Add(1, "One");
            equipmentDictionary.Add(3, "Three");
            equipmentDictionary.Add(5, "Five");
            equipmentDictionary.Add(4, "Four");
            equipmentDictionary.Add(2, "Two");

            Console.WriteLine($"Value is :{equipmentDictionary[3]}");

            try
            {
                Console.WriteLine(equipmentDictionary[6]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception caught: {e.Message}");
            }

            string retValue;

            var isPresent = equipmentDictionary.TryGetValue(6, out retValue); // returns false

            var isPresent1 = equipmentDictionary.TryGetValue(1, out retValue); // returns true, value of retValue is One.

            var hasKey = equipmentDictionary.ContainsKey(1); //check to prevent adding duplicate keys and avoid exeptions.

            equipmentDictionary.Remove(5);
            
        }
    }
}
