using Hotel.Utilies.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Models
{
    class HotelClass
    {
        private Room[] rooms = new Room[0];
        public string Name { get; set; }
        public Room this[int index]
        {
            get
            {
                if (rooms.Length > index && index >= 0)
                {
                    return rooms[index];
                }
                throw new Exception("Bele index yoxdur");
            }
            set
            {
                if (rooms.Length > index && index > 0)
                {
                    rooms[index] = value;
                    return;
                }
                throw new Exception("Bele index yoxdur");
            }
        }
        public HotelClass(string name)
        {
            Name = name;
        }

        public void AddRooms(params Room[] arr)
        {
            //arr{0,1,2} -> Resize(6) (3,6,8) arr[3] =3, arr[4]=6, arr[5] = 8
            int tempLength = rooms.Length;
            Array.Resize(ref rooms, rooms.Length+arr.Length);
            int roomI = 0;
            for (int i = tempLength; i < rooms.Length; i++)
            {
                rooms[i] = arr[roomI];
                roomI++;
            }
        }
        public void Reserve(int? number)
        {
            
            if (!(number is null)) //number -> 4,null
            {
                if (!(rooms[(int)number-1] is null)) //rooms[4]
                {
                    if (rooms[(int)number - 1].IsAvaible)
                    {
                        rooms[(int)number - 1].IsAvaible = false;
                    }
                    else
                    {
                        throw new NotAvaibleException("Otaq doludu");
                    }
                }
                else
                {
                    throw new NotFoundException("Otaq yoxdur");
                }
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public override string ToString()
        {
            string result = Name + ": \n";
            foreach (var item in rooms)
            {
                result += "\n";
                result += item.ToString();
                result += "\n";
            }
            return result;
        }
    }
}
