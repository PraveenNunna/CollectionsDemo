using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class ArrayDemo
    {
        public void DemoArray()
        {
            int[] numbers = new int[10]; // fized array with size defined upfront.
            numbers[0] = 0;
            numbers[1] = 1;

            int[] numbers1 = new int[] { 1, 2, 3, 4, 5 }; // array created with values.

            //No array.Add
            //No array.Removed
            //Fixed in size.

            Employee[] employees = new Employee[5];
            employees[0] = new Employee { Id = 1, Name = "" };

            //We cant resize array once created.
            //To remove objects inserted at the first, it will be difficult often involving in create a array altogether.

            var elist = employees.ToList<Employee>(); //employees.ToList();

            elist.Add(new Employee());
            elist.Remove(new Employee());
        }
    }
}
