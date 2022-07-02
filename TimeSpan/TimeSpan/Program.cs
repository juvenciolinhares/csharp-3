using System;

namespace DuracaoDeTempoTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*TIMESPAN é muito usado para calcular multa, juros, etc*/
            
            
            //hora, minuto, segundo:
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            ////TimeSpan com ticks:
            Console.WriteLine("ticks: "+ t1.Ticks);//100 nanosegundos - 1 minuto e meio que é 90 segundos da 900000000
            Console.WriteLine("---------------------------------------------");

            /*CONSTRUTORES DO TIMESPAN:*/

            //construtor vazio:
            TimeSpan construtorVazio = new TimeSpan();
            Console.WriteLine(construtorVazio);//duração zero
            Console.WriteLine("---------------------------------------------");

            //construtor ticks como parametro:
            TimeSpan construtorTicks = new TimeSpan(900000000L);
            Console.WriteLine("900000000 é equivalente a 1 minuto e meio: " + construtorTicks);
            Console.WriteLine("---------------------------------------------");

            //construtor hora, minuto, segundo:
            TimeSpan construtorHoraMinutoSegundo = new TimeSpan(2, 11, 21);
            Console.WriteLine(construtorHoraMinutoSegundo);
            Console.WriteLine("---------------------------------------------");

            //construtor dias, hora, minuto, segundo:
            TimeSpan construtorDiasHoraMinutoSegundo = new TimeSpan(1, 2, 11, 21);//1.02:11:21(1. => dia)
            Console.WriteLine(construtorDiasHoraMinutoSegundo);
            Console.WriteLine("---------------------------------------------");

            //construtor dia, hora, minuto, segundo, milisegundo:
            TimeSpan construtorDiaHoraMinutoSegundoMilisegundo = new TimeSpan(1, 2, 11, 21, 321);// 1.02:11:21.3210000
            Console.WriteLine(construtorDiaHoraMinutoSegundoMilisegundo);
            Console.WriteLine("---------------------------------------------");

            /*TIMESPAN UTILIZANDO O FROM:*/
            //permite "conversar" na unidade que eu quiser

            //criar um timespan equivalente a 1 dia e meio:
            TimeSpan umDiaEMeio = TimeSpan.FromDays(1.5);
            Console.WriteLine("equivalente a 1 dia e meio: "+ umDiaEMeio);//imprime: 1.12:00:00
            Console.WriteLine("---------------------------------------------");

            //criar um timespan FROMHOURS:
            TimeSpan paraHoras = TimeSpan.FromHours(1.5);
            Console.WriteLine("equivalente a 1 hora e meia: " + paraHoras);//imprime:01:30:00
            Console.WriteLine("---------------------------------------------");

            //criar um timespan FROMMINUTES:
            TimeSpan paraMinutos = TimeSpan.FromMinutes(1.5);
            Console.WriteLine("equivalente a 1 minuto e meio: " + paraMinutos);//imprime:00:01:30
            Console.WriteLine("---------------------------------------------");

            //criar um timespan FROMSECONDS:
            TimeSpan paraSegundos = TimeSpan.FromSeconds(1.5);
            Console.WriteLine("equivalente a 1 segundo e meio: " + paraSegundos);
            Console.WriteLine("---------------------------------------------");

            //criar um timespan FromMilliseconds:
            TimeSpan paraMilisegundos = TimeSpan.FromMilliseconds(1.5);
            Console.WriteLine("equivalente a 1 milisegundo e meio: " + paraMilisegundos);//o milisegundo pode ser quebrado pq sua unidade é o tick
            Console.WriteLine("---------------------------------------------");

            //criar um timespan FROMTicks:
            TimeSpan paraTicks = TimeSpan.FromTicks(900000000L);//SÓ ACEITA LONG
            Console.WriteLine("equivalente a 1 minuto e meio quando convertido: " + paraTicks);
            Console.WriteLine("---------------------------------------------");





        }
    }
}
/*
 * o DateTime representa um instante.
 * o TimeSpan REPRESENTA UMA DURAÇÃO(intervalo entre dois instantes)
 * é um struct
 * 
 * representação interna:
 * armazena a duração em forma de ticks(100 nanosegundos)
 */