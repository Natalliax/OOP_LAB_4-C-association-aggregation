using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_LAB_4
{
    public class Hotel
    {
        public enum Allocation { Yes = 0, No = 1, Repeate = -1 };
        public Hotel(): this("noname", "VIP")
        {

        }
        public Hotel(string name)
        {
            Name = name;
            rooms = new Room[2];
            rooms[0] = new Room("VIP", 10);
        }
         
        public Allocation highLightRoom(Client client)
        {
            foreach (Room room in rooms)
            {
                if (room?.client?.ClientName == client?.ClientName)
                {
                    return Allocation.Repeate;
                }
            }
            for(int i = 0; i < rooms.Length; i++)
            {
                if(rooms[i].client == null)
                {
                    rooms[i].client = client;
                    client.room = rooms[i];
                    return Allocation.Yes;
                }
            }
            return Allocation.No;
        }

        public string Name { get; set; }
        Room[] rooms;

        public Hotel(string name, params Room[] rooms) : this(name)
        {
            this.rooms = rooms;
        }

        
        public Hotel(string name, params string[] roomNames):this(name)
        {
            rooms = new Room[roomNames.Length];
            for (int i = 0; i < roomNames.Length; i++)
            {
                rooms[i] = new Room(roomNames[i], 100);
            }
        }

        public override string? ToString()
        {
            string str = $"ОТЕЛЬ {Name}. Номерной фонд {rooms.Length}\n";
            foreach (Room room in rooms)
            {
                str += $"{room}\n";
            }
            return str + "\n";

        }

    }
}
