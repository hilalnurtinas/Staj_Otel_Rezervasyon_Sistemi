

namespace OtelRezervasyonSistemi
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Hotel hotel1 = new Hotel("London Hotel", "London UK", "05556667788");
            Hotel hotel2 = new Hotel("Istanbul Hotel", "Istanbul TR", "05551112233");

            Customer customer1 = new Customer("Hilal Nur Tınas", 11111111);
            customer1.makeRezervation(hotel1, "suit", 3);
            customer1.makeRezervation(hotel2, "family", 5);
            customer1.makeRezervation(hotel1, "suit", 4);
            customer1.listCostumerRezervations();

            Console.WriteLine("***************************************************");

            customer1.getInvoice(20230002); //verilen rezervasyon numarasina ait odeme bilgileri

            Console.WriteLine("***************************************************");

            Customer customer2 = new Customer("Ayse Ozturk", 12345678);
            customer2.makeRezervation(hotel2, "family", 4);
            customer2.listCostumerRezervations();

            Console.WriteLine(hotel2.ToString());
        }
    }
}
