using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CollectionsDemo
{
    class ListDemo
    {
        public void DemoList()
        {
            List<string> team = new List<string>();

            team.Add("Zbyszek");
            team.Add("Marek");
            team.Add("Krzysztof");
            team.Add("Artur");
            team.Add("Michal");
            team.Add("Praveen");
            team.Add("New Member");

            team.Remove("New Member");


            var employees = new List<Employee>();
            employees.Add(new Employee { Id = 1, Name = "Zbyszek" });
            employees.Add(new Employee { Id = 2, Name = "Marek" });
            employees.Add(new Employee { Id = 3, Name = "Krzysztof" });
        }
    }
}
