using Homework_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ConsoleApp.Repositories
{
    public class CustomerRepository
    {
        //Kullanıcının girdiği TC Kimlik Numarasını döndüren fonksiyon.
        public static string GetCustomersID()
        {
            Console.WriteLine("Please write your TC Identity Number: ");
            return Console.ReadLine();
        }


        //Eğer kullanıcı mevcut değilse kullanıcıdan bilgilerini girmesini ister. Elde ettiği bilgiler ile yeni bir kullanıcı nesnesi
        //yaratıp bilgileri içerisine atar ve sonrasında parametre olarak girilen customerList listesine yeni elemanı ekler.
        //Sonrasında yeni eklediği Customer'i döndürür.
        public static Customer AddCustomer(List<Customer> customerList)
        {
            Console.WriteLine("You do not have an account!\nPlease write your TC Identity Number for new account: ");
            string newIdentityNumber = Console.ReadLine();

            Console.WriteLine("Please write your name: ");
            string newName = Console.ReadLine();

            Console.WriteLine("Please write your surname: ");
            string newSurname = Console.ReadLine();

            Console.WriteLine("Please write your mail: ");
            string newMail = Console.ReadLine();

            Console.WriteLine("Please write your phone number: ");
            string newPhone = Console.ReadLine();

            var newCustomer = new Customer()
            {
                CustomerId = customerList.Count,
                Name = newName,
                Surname = newSurname,
                Mail = newMail,
                IdentityNumber = newIdentityNumber,
                Phone = newPhone
            };
            customerList.Add(newCustomer);

            return newCustomer;
        }
    }
}
