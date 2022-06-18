using Homework_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ConsoleApp.Seeds
{
    public class SeedCustomerList
    {
        //Uygulamada kullanılması için gönderilen customerList'e default değerler ekleyen fonksiyon.
        public static void SeedData(List<Customer> customerList)
        {
            var defaultCustomer = new Customer()
            {
                CustomerId = 1,
                Name = "Ayşenur",
                Surname = "Dağdelen",
                Mail = "ays@mail.com",
                IdentityNumber = "12345678910",
                Phone = "+905055055050"
            };
            customerList.Add(defaultCustomer);
            var defaultCustomer2 = new Customer()
            {
                CustomerId = 2,
                Name = "Fırat",
                Surname = "Kahreman",
                Mail = "firat@mail.com",
                IdentityNumber = "12345678920",
                Phone = "+905051011010"
            };
            customerList.Add(defaultCustomer2);            
        }
    }
}
