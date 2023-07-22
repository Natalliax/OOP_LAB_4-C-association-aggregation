using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4
{
    public class Room
    {
        public Room(string descriptionRoom, int floor )
        {
            this.DescriptionRoom = descriptionRoom;
            this.Floor = floor;

        }

        public string DescriptionRoom { get; set; }
        public int Floor { get; set; }
        public Client? client = null;
        

        public override string? ToString()
        {
            string str = $"Номер {DescriptionRoom} этаж {Floor}\n";

            if (client == null)
            {
                str += " Свободно\n";
            }
            else
            {
                str += $"Занято клиентом {client.ClientName}";
            }
            return str;      
        }


    }
}
