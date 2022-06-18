using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_ConsoleApp.Models
{
    public class Order
    {
        public int Total { get; set; }
        public string Color { get; set; }

        public Customer Customer { get; set; }
        public Product Product { get; set; }
    }
}
