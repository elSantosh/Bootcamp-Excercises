using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsExample
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Order
    {
        public string OrderNumber { get; set; }

        public string CustomerName { get; set; }

        public string ProductName { get; set; }

        public decimal Payment { get; set; }

        public string Address { get; set; }
    }

    public class Store
    {
        private static int _runningOrderNumber = 0;

        public Order OrderAProduct(string productName, string customerName)
        {
            if (string.IsNullOrWhiteSpace(customerName))
            {
                throw new ArgumentException(customerName, "Customer name cannot be empty.");
            }

            var order = new Order();
            order.ProductName = productName;
            order.CustomerName = customerName;
            order.OrderNumber = (++_runningOrderNumber).ToString();

            return order;
        }

        public Order PayForProduct(Order order, decimal payment)
        {
            order.Payment = payment * (decimal)0.06;

            return order;
        }

        public Order DeliverOrder(Order order, string address)
        {
            order.Address = address;

            return order;
        }
    }

    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return (first - second);
        }
    }
}
