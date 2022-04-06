using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Orderlist
    {
        public int Id { get; set; }
        public List<Order>orders { get; set; }
        public double Totalprice { get; set; }
    }
}
