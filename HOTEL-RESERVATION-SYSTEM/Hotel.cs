using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_RESERVATION_SYSTEM
{
    internal class Hotel
    {
        public string Name { get; set; }
        private Room[] Rooms { get; set; } = new Room[0];
        public Hotel(string name, Room[] rooms)
        {
            Name = name;
            Rooms = rooms;
        }
        public Hotel(string name)
        {
            Name = name;
        }
        public void AddRoom(Room room)
        {
            Room[] temp = Rooms;

            Array.Resize(ref temp, temp.Length + 1);

            temp[temp.Length - 1] = room;

            Rooms = temp;
        }

    }
}
