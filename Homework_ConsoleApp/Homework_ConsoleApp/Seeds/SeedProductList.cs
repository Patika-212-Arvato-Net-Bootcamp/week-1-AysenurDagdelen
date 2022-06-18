using Homework_ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ConsoleApp.Seeds
{
    public class SeedProductList
    {
        //Uygulamada kullanılması için gönderilen productList'e default değerler ekleyen fonksiyon.
        public static void SeedData(List<Product> productList)
        {
                var defaultProduct = new Product()
                {
                    ProductId = 1,
                    ProductName = "Sneakers"
                };
                productList.Add(defaultProduct);

                var defaultProduct2 = new Product()
                {
                    ProductId = 2,
                    ProductName = "T-Shirt"
                };
                productList.Add(defaultProduct2);

                var defaultProduct3 = new Product()
                {
                    ProductId = 3,
                    ProductName = "Cap"
                };
                productList.Add(defaultProduct3);
            
        }
    }
}
