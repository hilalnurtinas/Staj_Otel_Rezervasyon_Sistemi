using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi
{
    public class Hotel
    {
        private string hotelName;
        private string address;
        private string telephone;
        private Room[] rooms = new Room[100];
            

        public Hotel(string hotelName, string address, string telephone)
        {
            this.HotelName = hotelName;
            this.Address = address;
            this.Telephone = telephone;


            // her otel nesnesi için default olarak 4 oda atama işlemi gerçekleştirilecek
            Rooms[0] = new Room(101, "standart", 100);
            Rooms[1] = new Room(201, "family", 200);
            Rooms[2] = new Room(301, "suit", 400);
            Rooms[3] = new Room(302, "suit", 400);
            Rooms[4] = new Room(201, "family", 200);
        }

        public string HotelName { get => hotelName; set => hotelName = value; }
        public string Address { get => address; set => address = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public Room[] Rooms { get => rooms; set => rooms = value; }



        //otel bilgilerini döndürdük
        public override string ToString()
        {
            return "Otelin Adı: " + hotelName + " Otelin Adresi: " + address + " Otelin Telefonu: " + telephone ;
        }



    }
}
