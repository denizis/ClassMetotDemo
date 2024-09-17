using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer musteri)
        {
            Console.WriteLine("Müşeti " + musteri.FirstName + " Eklendi !");
        }
        public void Delete(Customer musteri)
        {
            Console.WriteLine("Müşteri " + musteri.FirstName + "Sistemden Silindi");
        }

        public void Update(Customer musteri)
        {
            Console.WriteLine("Müşteri " + musteri.FirstName + " Bilgileri Güncellendi");

        }
        public void List(Customer musteri)
        {
            Customer[] Customers = new Customer[] { };


        }
    }
}