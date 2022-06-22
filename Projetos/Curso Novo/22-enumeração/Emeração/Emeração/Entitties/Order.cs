using System;
using Emeração.Entitties.Enuns;

namespace Emeração.Entitties
{
    class Order
    {
        public int Id { get; set; }

        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return ($"{Id}, {Moment}, {Status}");
        }
    }
}
