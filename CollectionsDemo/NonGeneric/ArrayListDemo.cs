using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Concurrent;

namespace CollectionsDemo.NonGeneric
{
    class ArrayListDemo
    {
        public void DemoArrayList()
        {
            ArrayList al = new ArrayList();

            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            al.Add("Praveen");
            al.Add("Nunna");
            al.Add(1.2);
            al.Add(new Employee());

            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);

            al[0] = "test";

            foreach (var a in al)
            {
                Console.WriteLine(a);
            }
        }
    }
}
