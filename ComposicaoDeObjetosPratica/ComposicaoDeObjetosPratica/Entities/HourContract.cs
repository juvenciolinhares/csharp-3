using System;

namespace ComposicaoDeObjetosPratica.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //construtores

        public HourContract()
        {
        }

        public HourContract(DateTime date, Double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //metodo:
        public double totalValue()
        {
            return ValuePerHour * Hours;// atributos
        }

    }
}
