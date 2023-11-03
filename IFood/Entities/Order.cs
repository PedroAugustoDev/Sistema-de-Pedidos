using IFood.Entities.Enums;
using System;

namespace IFood.Entities
{
    class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; private set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;    
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0d;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            } return total;
        }

        public override string ToString()
        {
            string itemDesc = "";
            foreach (OrderItem item in Items){ itemDesc += "\n" + " " + item.ToString(); }
            return
                $"Data do Pedido {Moment}\n" +
                $"Status do Pedido {Status}\n" +
                $"Cliente {Client}\n" +
                "Items:" + itemDesc + "\n"+
                $"Total: R${Total()}";
        }
    }
}
