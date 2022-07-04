using System;
using Enumeracoes.Entities;//importar o entities
using Enumeracoes.Entities.Enums;//importar enums



namespace Enumeracoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            //conversão de string para enumeração:
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);//imprime o pendigpayment como texto


            //conversão de enumeração para string:
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);


           
        }
    }   

}
    

