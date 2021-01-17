using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void AddCustomer(Musteri musteri)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Müşteri adı:" + musteri.Name + " Müşteri soyadı:" + musteri.Surname
                + " Müşteri id:" + musteri.Id + " \nMüşteri eklenmiştir.");
        }

        public void ListCustomer(Musteri musteri)
        {

            Console.WriteLine("---------");
            Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Name);
                Console.WriteLine(musteri.Surname);
          
           
           
        }

        public void DeleteCustomer(Musteri musteri)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Müşteri adı:"+musteri.Name+ " Müşteri soyadı:"+musteri.Surname
                +" Müşteri id:"+musteri.Id+ " \nMüşteri silinmiştir.");
        }
    }
}
