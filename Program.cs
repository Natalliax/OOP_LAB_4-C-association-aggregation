using OOP_LAB_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP_LAB_4
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Client client1 = new Client("Артур");
            Console.WriteLine(client1);

            Client client2 = new Client("Николь");
            Console.WriteLine(client2);

            Client client3 = new Client("Алекс");
            Console.WriteLine(client3);

            Room room1 = new Room("Стандарт", 25);
            Console.WriteLine(room1);


            Room room2 = new Room("Эконом", 10);
            Console.WriteLine(room2);


            Hotel hotel1 = new Hotel("ГрандОтель", room1, room2);
            Console.WriteLine(hotel1);

            Console.WriteLine($"Клиент {client1.ClientName} бронирует номер в отеле {hotel1.Name}");
            code_ex(client1.LandingRequest(hotel1));
            Console.WriteLine(hotel1);

            Console.WriteLine($"Клиент {client1.ClientName} бронирует номер в отеле {hotel1.Name}");
            code_ex(client1.LandingRequest(hotel1));
            Console.WriteLine(hotel1);

            Console.WriteLine($"Клиент {client2.ClientName} бронирует номер в отеле {hotel1.Name}");
            code_ex(client2.LandingRequest(hotel1));
            Console.WriteLine(hotel1);


            Console.WriteLine($"Клиент {client3.ClientName} бронирует номер в отеле {hotel1.Name}");
            code_ex(client3.LandingRequest(hotel1));
            Console.WriteLine(hotel1);

            Console.ReadKey();
        }


        static void code_ex(Hotel.Allocation code)
        {
            switch (code)
            {
                case Hotel.Allocation.Repeate:
                    Console.WriteLine("Отказано. Номер уже забронирован Вами");
                    break;

                case Hotel.Allocation.Yes:
                    Console.WriteLine("Номер забронирован Вами");
                    break;

                case Hotel.Allocation.No:
                    Console.WriteLine("Отказано. Нет свободных номеров");
                    break;
            }
        }
    }
}


