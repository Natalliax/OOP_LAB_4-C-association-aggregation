using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4
{
    public class Client
        
    {
        public string ClientName { get; set; }
        public Room? room = null;
        public Client(string clientName)
        {
            ClientName = clientName;
        }

        public Hotel.Allocation LandingRequest(Hotel hotel)
        {
            return hotel.highLightRoom(this);
        }

        public override string? ToString()
        {
           string str =  $"Имя клиента {ClientName}\n";
            if (room == null)
                str += "номер забронирован клиентом\n";
            else
                str += $"номер свободный {room?.DescriptionRoom}";
            return str ;
        }
    }
}
