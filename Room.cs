using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi
{
    public class Room
    {
        private int roomNumber;
        private string roomType;
        private double price;
        private bool isAvaliable;

        //constructor method -- ilk çalıştırılan method
        public Room(int roomNumber, string roomType, double price)
        {
            this.roomNumber = roomNumber;
            this.roomType = roomType;   
            this.price = price; 
            this.isAvaliable = true; //olusturulan odanın ulasılabilirlik durumu
        }

        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public double Price { get => price; set => price = value; }
        public bool IsAvaliable { get => isAvaliable; set => isAvaliable = value; }


    }
}




