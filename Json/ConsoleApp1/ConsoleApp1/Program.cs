using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Computer computer = new Computer { Id = 1, Brand = "acer", Ram = "16Gb", Grapics = "RTX 2080", Price = 2200 };
            Computer computer1 = new Computer { Id = 2, Brand = "lenova", Ram = "8Gb", Grapics = "GTX 1060", Price = 1800 };
            Computer computer2 = new Computer { Id = 3, Brand = "omen", Ram = "32Gb", Grapics = "RTX 3080", Price = 3200 };

            Order order = new Order { Id = 1, computer = computer, Price = computer.Price };
            Order order1 = new Order { Id = 1, computer = computer1, Price = computer1.Price };
            Order order2 = new Order { Id = 1, computer = computer2, Price = computer2.Price };

            Orderlist orderlist = new Orderlist
            {
                Id = 1,
                orders = new System.Collections.Generic.List<Order>()
                {
                    order,
                    order1,
                    order2,

                },
                Totalprice = 7200
            };
            //Console.WriteLine(orderlist.orders[1].Price);

            var ordersl = JsonConvert.SerializeObject(orderlist);
            Console.WriteLine(ordersl);
            using(StreamWriter streamWriter = new StreamWriter(@"C:\Users\User\Desktop\Task\4\ConsoleApp1\ConsoleApp1\data.Json"))
            {
                streamWriter.WriteLine(ordersl);
            }
        }


    }
}
