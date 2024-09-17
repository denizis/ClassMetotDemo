using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Deniz";
            customer1.Lastname = "İskender";
            customer1.Id = 1;
            customer1.Description = "Bankamızın ilk Müşterisi";



            Customer customer2 = new Customer();
            customer2.FirstName = "Mustafa";
            customer2.Lastname = "Gökdeniz";
            customer2.Id = 2;
            customer2.Description = "Bankaya para yatırdı";


            Customer[] Customers = new Customer[] { customer1, customer2 };
            Console.WriteLine("-----------Müşterlerin Bilgileri----------------");
            
            foreach (Customer customer in Customers)
            { 
                
                Console.WriteLine("Adı:"+customer.FirstName);
                Console.WriteLine("Soyadı:"+customer.Lastname);
                Console.WriteLine("Müşterinin Id si:"+customer.Id);
                Console.WriteLine("Dosya Açıklamsı:"+customer.Description);
                

            }
            Console.WriteLine("-------------------------");

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer2);
            customerManager.Delete(customer2);
         
        
            Console.ReadLine();



        }
    }
}
