﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ListDemo
{
    class EquipmentListDemo
    {
        public void DemoEquipementList()
        {
            var equipments = new List<Equipment>();
            equipments.Add(new Equipment("Bench", 1));
            equipments.Add(new Equipment("Connector", 5));
            equipments.Add(new Equipment("Cable", 3));
            equipments.Add(new Equipment("Board", 4));
            equipments.Add(new Equipment("Unit", 2));
            equipments.Add(new Equipment("Computer", 6));
            equipments.Add(new Equipment("Connector", 5));

            var dist = equipments.Distinct(); // For Distinct to work, we need to override GetHashCode methos in custom object.

            var group = equipments.GroupBy(e => e.Id);

            equipments.Sort();

            var test  = equipments.Where(e => e.Id  == 4);

            var names = equipments.Where(e => e.Id == 4).Select(e => e.Name).ToList();

            var newObj = new Equipment("Unit", 2);

            Console.WriteLine($"Contains test:{equipments.Contains(newObj)}"); // Won't possible if we dont have IEquatable implementation.

            equipments.GetFirstEquipmentCount();
        }
    }

    public class Equipment : Object,IEquatable<Equipment>, IComparable<Equipment>
    {
        public string Name { get; set; }

        public int Id { get; set; }

        
        public Equipment(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public bool Equals(Equipment other)
        {
            var equp = (Equipment)other;
            if (equp == null) return false;

            if (equp.Id == this.Id) return true;

            return false;
        }

        public int CompareTo(Equipment other)
        {
            if (other == null) return 1;
            //-1 
            // 0
            //1
            return Id.CompareTo(other.Id);
        }
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }

    public static class EmployeeExtensions
    {
        public static int GetFirstEquipmentCount(this List<Equipment> list)
        {
            return list.Count(l => l.Id > 5);
        }
    }
}
