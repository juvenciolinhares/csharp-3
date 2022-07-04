using System;
using Enumeracoes.Entities.Enums; // "importar o OrderStatus"


namespace Enumeracoes.Entities
{
    internal class Order
    {
        //atributos:
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
