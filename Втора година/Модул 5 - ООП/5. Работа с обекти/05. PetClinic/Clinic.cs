using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._PetClinic
{
    class Clinic
    {
        private string name;
        private int roomCount;
        private Dictionary<int, Pet> rooms;
        private int centralRoom;

        public Clinic(string name, int roomCount)
        {
            Name = name;
            RoomCount = roomCount;

            centralRoom = (int)Math.Ceiling(RoomCount / 2.0);
            rooms = new Dictionary<int, Pet>(RoomCount);

            for (int i = 1; i <= RoomCount; i++)
            {
                rooms.Add(i, null);
            }

        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value.Length > 50 || value.Any(char.IsDigit))
                {
                    throw new ArgumentException();
                }

                name = value;
            }
        }

        private int RoomCount
        {
            get { return roomCount; }
            set
            {
                if (value % 2 == 0)
                {
                    throw new ArgumentException();
                }

                roomCount = value;
            }
        }

        private List<int> GetAddOrder()
        {
            List<int> result = new List<int>();

            int current = centralRoom;
            int diff = -1;

            while (current >= 1 && current <= RoomCount)
            {
                result.Add(current);
                current += diff;
                if (diff > 0)
                {
                    diff++;
                }
                else
                {
                    diff--;
                }
                diff = -diff;
            }

            return result;
        }

        public bool Add(Pet pet)
        {
            foreach (int i in GetAddOrder())
            {
                if (rooms[i] == null)
                {
                    rooms[i] = pet;
                    return true;
                }
            }

            return false;
        }

        public bool Release()
        {
            for (int i = centralRoom; i <= roomCount; i++)
            {
                if (rooms[i] != null)
                {
                    rooms[i] = null;
                    return true;
                }
            }
            
            for (int i = 1; i < centralRoom; i++)
            {
                if (rooms[i] != null)
                {
                    rooms[i] = null;
                    return true;
                }
            }

            return false;
        }

        public bool HasEmptyRooms()
        {
            return rooms.Any(r => r.Value == null);
        }

        public void Print()
        {
            foreach (KeyValuePair<int, Pet> room in rooms)
            {
                Console.WriteLine(room.Value != null ? room.Value.ToString() : "Room empty");
            }
        }

        public void Print(int room)
        {
            Console.WriteLine(rooms[room].ToString());
        }
    }
}
