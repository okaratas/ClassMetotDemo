using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name = "Burcu";
            musteri1.Surname = "Eren";
            musteri1.Id = 8970;

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Elif";
            musteri2.Surname = "Çetin";
            musteri2.Id = 2674;

            Musteri musteri3 = new Musteri();
            musteri3.Name = "Beliz";
            musteri3.Surname = "Yılmaz";
            musteri3.Id = 2546;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.AddCustomer(musteri);
              
            }

            Console.WriteLine("\nBütün müşteriler");
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.ListCustomer(musteri);
            }

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.DeleteCustomer(musteri);
            }


        }
    }
}
