using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Power of List<T>
1) Important methods
	Add, AddRange
	Contains()
	Remove , RemoveAll
	Insert()
	Clear()
	Count()
	Contains()
	IndexOf()

	AsReadOnly()
	
2) Important Properties
	Capacity
	Count
	[]
	
3) Working with custom objects
	Equality
	Comparability
	
4) List<T> Capabilities
*/
namespace ListDemo
{
    class ListDemo
    {
        public void DemoList()
        {
            var smallList = new List<string>();
            smallList.Add("Wroklaw");
            smallList.Add("Gdansk");

            var mainList = new List<string>();
            mainList.Add("Warsaw");
            mainList.Add("Lodz");
            mainList.Add("Krakow");

            mainList.AddRange(smallList);

            Console.WriteLine($"The count of cities is : {mainList.Count}");
            Console.WriteLine($"The capacity of the list is : {mainList.Capacity}");

            Console.WriteLine($"Lodz present in Cities? : {mainList.Contains("Lodz")}");
            Console.WriteLine($"Katowice present in Cities? : {mainList.Contains("Katowice")}");

            smallList.Remove("Gdansk");
            smallList.Add("Gdansk");
            smallList.Add("Gdansk");
            smallList.Add("Gdansk");

            smallList.RemoveAll(sl => sl == "Gdansk"); //sl.Contains, sl.Count.. etc

            mainList.Insert(3, "Katowice");

            Console.WriteLine($"Position of Lodz in list is: {mainList.IndexOf("Lodz")}");

            List<int> integers = new List<int> { 5, 6, 9, 8, 7, 2, 3, 1, 4 };
            integers.Sort();

            mainList.Sort();

            //enumerating lists.
            //Using a method
            //using for loop
            //using lambda expression
        }
    }
}
