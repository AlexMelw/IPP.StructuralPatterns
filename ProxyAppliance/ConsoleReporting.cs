﻿namespace ProxyAppliance
{
    using System;
    using Model;

    public class ConsoleReporting
    {
        public static void PrintOrderDetails(Order order)
        {
            Console.WriteLine("Displaying Order Information:");
            Console.WriteLine("Order Date: " + order.OrderDate.Date);
            Console.WriteLine("Customer: " + order.Customer.Name);
        }
    }
}