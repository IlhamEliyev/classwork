using Hotel.Models;
using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("Room1",100,3);
            Room room2 = new Room("Room2",150,2);
            HotelClass h = new HotelClass("Hilton");
            h.AddRooms(room1,room2);
            h.Reserve(2);
            h.Reserve(7);
            Console.WriteLine(h);
        }
    }
}
