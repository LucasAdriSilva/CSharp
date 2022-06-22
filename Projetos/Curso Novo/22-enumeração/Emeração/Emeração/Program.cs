using System;
using Emeração.Entitties.Enuns;
using Emeração.Entitties;


namespace Emeração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
            Console.ReadKey();
            Console.Clear();

            //Convertando enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);
            Console.ReadKey();
            Console.Clear();

            //Convertendo enum para string
            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
            Console.WriteLine(os);


        }
    }
}
