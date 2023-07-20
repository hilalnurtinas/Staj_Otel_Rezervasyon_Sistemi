using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi
{
    public class Customer
    {
        private string name;
        private int identityID;
        private Rezervation[] rezervations = new Rezervation[10];

        public Customer(string name, int identityID)
        {
            this.name = name;
            this.identityID = identityID;
        }

        public string Name { get => name; set => name = value; }
        public int IdentityID { get => identityID; set => identityID = value; }
        public Rezervation[] Rezervations { get => rezervations; set => rezervations = value; }


        public void makeRezervation(Hotel hotel, string roomType, int day)
        {
            int roomNumber = 0;
            Room[] rooms = hotel.Rooms;

            int i = 0;
            while ((rooms[i] != null) && (rooms[i].IsAvaliable == false || rooms[i].RoomType.CompareTo(roomType) != 0))
            {
                i++;
            }
            if (rooms[i] != null)
            {
                roomNumber = rooms[i].RoomNumber;
                rooms[i].IsAvaliable = false;
                Rezervation rezervation = new Rezervation(hotel, roomNumber, day);
                
                appendRezervation(rezervation);
            }
            else
            {
                Console.WriteLine("Sectiginiz oda tipinin musaitlik durumu bulunmamaktadır !!!");
            }

        }

        private void appendRezervation(Rezervation rezervation)
        {
            int i = 0;

            while (rezervations[i] != null && i < rezervations.Length)
            {
                i++;
            }
            if (rezervations[i] == null)
            {
                rezervations[i] = rezervation;
            }

        }

        public void getInvoice(int rezervationID)
        {
            int i = 0;
            while (rezervations[i].RezervationID != rezervationID)
            {
                i++;
            }
            if (rezervations[i].RezervationID == rezervationID)
            {
                rezervations[i].calculatePayment();
            }
        }

        public void listCostumerRezervations()
        {
            int i = 0;
            while (rezervations[i] != null)
            {
                Console.WriteLine(rezervations[i]);
                i++;
            }
        }


    }
}
