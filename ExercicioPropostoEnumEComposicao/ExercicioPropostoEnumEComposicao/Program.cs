using System;
using System.Globalization;
using ExercicioPropostoEnumEComposicao.Entities;
using ExercicioPropostoEnumEComposicao.Entities.Enums;

namespace ExercicioPropostoEnumEComposicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //dados do cliente
            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, email, birthDate);
            Order order = new Order( DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Produc name: ");//nome produto=> product
                string nameProduct = Console.ReadLine();
                Console.Write("Produc price: ");//preco=> orderitem
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");//qtd=>
                int quantity = int.Parse(Console.ReadLine());

                Product produto = new Product(nameProduct, price);
                OrderItem item = new OrderItem(quantity, price, produto);

                order.AddItem(item);

            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
            


        }
    }
}
