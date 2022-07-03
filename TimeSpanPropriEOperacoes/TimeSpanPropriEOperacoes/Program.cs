using System;

namespace TimeSpanPropriEOperacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //duração máxima, mínima possivel de se armazenar num timespan e duração zero:

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;
            Console.WriteLine("Duração máxima: " + t1);
            Console.WriteLine("Duração mínima: " + t2);
            Console.WriteLine("Duração zero: " + t3);
            Console.WriteLine("----------------------------------------------------");

            /*PROPRIEDADES PRA PEGAR CADA UM DOS VALORES DO TIMESPAN:*/
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            Console.WriteLine(t);

            //RETORNAM NUMERO INT:
            //pegar os dias:
            Console.WriteLine("dias contidos nesse timeSpan: " + t.Days);
            //pegar os horas:
            Console.WriteLine("horas contidas nesse timeSpan: " + t.Hours);
            //pegar os minutos:
            Console.WriteLine("minutos contidos nesse timeSpan: " + t.Minutes);
            //pegar os milisegundos:
            Console.WriteLine("milisegundos contidos nesse timeSpan: " + t.Milliseconds);
            //pegar os segundos:
            Console.WriteLine("segundos contidos nesse timeSpan: " + t.Seconds);
            //pegar os ticks:
            Console.WriteLine("ticks contidos nesse timeSpan: " + t.Ticks);

            Console.WriteLine("----------------------------------------------------");

            //RETORNAM NUMERO DOUBLE:
            //total de dias
            Console.WriteLine("Total de dias: " + t.TotalDays);
            //total de horas
            Console.WriteLine("Total de horas: " + t.TotalHours);
            //total de minutos
            Console.WriteLine("Total de minutos: " + t.TotalMinutes);
            //total de segundos
            Console.WriteLine("Total de  segundos: " + t.TotalSeconds);
            //total de milisegundos
            Console.WriteLine("Total de milisegundos: " + t.Milliseconds);
            Console.WriteLine("----------------------------------------------------");

            /*PROPRIEDADES PRA PEGAR CADA UM DOS VALORES DO TIMESPAN:*/

            TimeSpan t4 = new TimeSpan(1, 30, 10);
            TimeSpan t5 = new TimeSpan(0, 10, 5);

            //soma dos dois timespan:
            TimeSpan soma = t4.Add(t5);
            Console.WriteLine("a soma é: " + soma);

            //diferença dos dois timespan:
            TimeSpan diferença = t4.Subtract(t5);
            Console.WriteLine("A diferença é: " + diferença);

            //multiplicação:
            TimeSpan multiplicacao = t4.Multiply(2.0);//recebe um double como argumento
            Console.WriteLine("A multiplicação de t4 por 2 é: " + multiplicacao);

            //Divisão:
            TimeSpan diferenca = t4.Divide(2.0);//recebe um double como argumento
            Console.WriteLine("A diferença de t4 por 2 é" + diferenca);

        }
    }
}
