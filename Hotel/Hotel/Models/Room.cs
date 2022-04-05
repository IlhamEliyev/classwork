using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Models
{
    class Room
    {
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvaible { get; set; } = true;
        public Room(string name, double price, int pc )
        {
            _id++;
            Id= _id;
            Name = name;
            Price = price;
            PersonCapacity = pc;
        }
        public string ShowInfo()
        {
            return $@"Id = {Id}
Name = {Name}
Price = {Price}
Person capacity = {PersonCapacity}
IsAvaible = {IsAvaible}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }
}
