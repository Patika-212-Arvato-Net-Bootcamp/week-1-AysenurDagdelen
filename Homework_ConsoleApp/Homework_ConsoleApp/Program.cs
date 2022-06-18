using Homework_ConsoleApp.Models;
using Homework_ConsoleApp.Repositories;
using Homework_ConsoleApp.Seeds;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Homework_ConsoleApp
{
    



    public class Program
    {               
        static void Main(string[] args)
        {

            //Customer ve Product modellerini kullanan yeni nesne örnekleri oluşturuldu.
            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();

            //TC Kimlik numarasını giren kullanıcının kayıtlı olup olmadığının kontrolü için tanımlandı.
            bool isMember = false;                             

            //customers ve products listelerine default değerler atamak için seed fonksiyonları yazıldı. 
            SeedCustomerList.SeedData(customers);                 
            SeedProductList.SeedData(products);

            //idNumber'a atamak için kulllanıcıdan TC Kimlik Numarası yazmasını isteyen fonksiyon.
            string idNumber = CustomerRepository.GetCustomersID();
            

            //Kullanıcıdan alınan TC Kimlik Numarası değerini customers listesi içerisindeki kullanıcıların IdentityNumber'ları ile
            //karşılaştıran foreach döngüsü ve içerisinde if koşulu yazıldı.
            foreach (var customer in customers)
            {
                if (idNumber==customer.IdentityNumber)
                {
                    //Eğer böyle bir kullanıcı mevcutsa isMember true değeri alır. Böylece yeni kayıt alınmasına gerek kalmaz.
                    isMember = true;

                    //Giriş yapan kullanıcı için karşılama mesajı.
                    Console.WriteLine("Welcome: " + customer.Name + "\n\n");

                    //products listesindeki Product'ları listeleyen fonksiyon.
                    OrderRepository.GetProducts(products);

                    //Customer'dan Order'ları alıp liste halinde geri döndüren fonksiyon.
                    List<Order> orders = OrderRepository.TakeOrder(customer, products);

                    //Alınan orders listesini anlamlaştırarak kullanıcıyı bilgilendiren fonksiyon.
                    OrderRepository.GetOrders(customer, orders);                                       
                }
            }

            //isMember true değeri almamışsa TC Kimlik Numarası customers listesindeki herhangi bir Customer'da bulunmuyor demektir.
            //if koşulu içerisine girer, yeni bir Customer oluşturmak için AddCustomer fonksiyonu customers listesi gönderilerek çağırılır
            //ve yeni kullanıcı customers listesine eklenmiş olur. Sonrasında bu fonksiyon yeni kullanıcıyı dönerek yeni kullanıcının
            //işleme devam etmesini sağlar.
            if (!isMember)
            {
                Customer newCustomer = CustomerRepository.AddCustomer(customers);

                Console.WriteLine("Welcome, " + newCustomer.Name + "\n\n");

                OrderRepository.GetProducts(products);

                List<Order> orders = OrderRepository.TakeOrder(newCustomer, products);

                OrderRepository.GetOrders(newCustomer, orders);
            }
        }
    }
}