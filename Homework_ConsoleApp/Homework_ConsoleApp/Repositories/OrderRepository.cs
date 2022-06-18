using Homework_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ConsoleApp.Repositories
{
    public class OrderRepository
    {
        //Parametre olarak aldığı productList'i anlamlı halde listeleyen fonksiyon.
        public static void GetProducts(List<Product> productList)
        {
            foreach (var product in productList)
            {
                Console.WriteLine("***************" + product.ProductName + "***************");
                Console.WriteLine(" ID: " + product.ProductId + "\n");
            }
        }


        //Kullanıcının sipariş vermesini sağlayan fonksiyon.
        public static List<Order> TakeOrder(Customer customer, List<Product> productList)
        {
            //orders isminde, verilen Order'ların listeleneceği nesne örneğini alır.
            List<Order> orders = new List<Order>();

            //Customer, daha fazla Order oluşturacaksa kullanılmak üzere oluşturulan değer.
            string moreOrder;
            

            //En az bir Order oluşturulacağı için Do-While yapısı kullanıldı. Önce bir Order oluşturulur, daha sonra istenirse While döngüsü ile
            //Order oluşturulmak istendiği sürece döngü devam eder. Customer'dan Product Id, Color, ve Adet değerleri alınır ve yeni bir Order 
            //objesi oluşturulur. Daha sonra bu obje orders listesine eklenir. Sonrasında listeyi geri döndürür.
            do
            {
                Console.WriteLine("\nPlease select product ID.");
                int pickProduct = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nPlease select color (Type 'red', 'blue', 'green', 'white' or 'black')");
                var pickColor = Console.ReadLine();
                Console.WriteLine("\nHow many do you want to order? (" + pickColor + " " + productList[pickProduct - 1].ProductName + ")");
                int pickTotal = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nYou ordered " + pickTotal + " " + pickColor + " " + productList[pickProduct - 1].ProductName);

                var myOrder = new Order()
                {
                    Color = pickColor,
                    Customer = customer,
                    Total = pickTotal,
                    Product = productList[(pickProduct - 1)]
                };

                orders.Add(myOrder);

                Console.WriteLine("\n\nDo you want to order another product? (y/n)");
                moreOrder = Console.ReadLine();
            } while (moreOrder == "y" || moreOrder == "Y");

            return orders;
        }


        //orderList listesini alarak Customer'ı oluşturduğu Order'lar konusunda haberdar eden fonksiyon.
        public static void GetOrders(Customer customer, List<Order> orderList)
        {
            for (int i = 0; i < orderList.Count; i++)
            {
                Console.WriteLine("\nYour " + (i+1) + ". order= " + orderList[i].Total + " piece " + orderList[i].Color + " " + orderList[i].Product.ProductName);
            }
            Console.WriteLine("\nCustomer = " + customer.Name + " " + customer.Surname);
        }



    }
}
