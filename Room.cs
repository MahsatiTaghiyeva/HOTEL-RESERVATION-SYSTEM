using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_RESERVATION_SYSTEM
{
    internal class Room
    {
        public static int Count = 0;
        private string Id { get;}
        public string Name { get; set; }
        public double Price { get; set; }
        public int PersonCapacity { get; set; }
        public bool IsAvailable = true;
        public Room(string name, double price, int personCapacity,bool isAvailable)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            IsAvailable = isAvailable;
        }
        public Room(string name, double price, int personCapacity)
        {
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
        }
        public string ShowInfo()
        {
            return $"Room ID: {Id}, Name: {Name}, Price: {Price}, Person Capacity: {PersonCapacity}, Is Available: {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }

    }
}
