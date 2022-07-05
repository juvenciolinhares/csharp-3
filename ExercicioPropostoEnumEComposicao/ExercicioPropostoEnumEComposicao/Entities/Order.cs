using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoEnumEComposicao.Entities.Enums;

namespace ExercicioPropostoEnumEComposicao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Cliente { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Order()
        {

        }
        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem (OrderItem item)
        {
            Itens.Add(item);

        }
        public void RemoveItem(OrderItem item)
        {
            Itens.Remove(item);
        }

        public double total()
        {
            double sum = 0.0;
            foreach(OrderItem item in Itens)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Cliente);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in Itens)
            {
                sb.Append(item.ToString());
            }
            sb.Append("Total Price: $");
            sb.AppendLine(total().ToString("F2",CultureInfo.InvariantCulture));
            return sb.ToString();
        }
        


    }

}
