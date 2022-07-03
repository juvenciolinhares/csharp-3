using System;

namespace PropriedadesDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PROPRIEDADES DATETIME:*/

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);

            //considerar a data e desconsiderar o horário:
            Console.WriteLine("1) Date: " + d.Date);// horário zerado
            Console.WriteLine("----------------------------------------------");

            //considerar apenas o dia:
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("----------------------------------------------");

            //considerar apenas o dia:
            Console.WriteLine("3) Dia da semana: " + d.DayOfWeek);
            Console.WriteLine("----------------------------------------------");

            //Dia do ano:
            Console.WriteLine("4) Dia do ano: " + d.DayOfYear);
            Console.WriteLine("----------------------------------------------");

            // hora::
            Console.WriteLine("5) hora: " + d.Hour);
            Console.WriteLine("----------------------------------------------");

            //tipo:
            Console.WriteLine("6) tipo: " + d.Kind);
            Console.WriteLine("----------------------------------------------");

            //milisegundos:
            Console.WriteLine("7) milisegundos: " + d.Millisecond);
            Console.WriteLine("----------------------------------------------");

            //minuto:
            Console.WriteLine("8) minuto: " + d.Minute);
            Console.WriteLine("----------------------------------------------");

            //mes:
            Console.WriteLine("9) mes: " + d.Month);
            Console.WriteLine("----------------------------------------------");

            //segundos:
            Console.WriteLine("10) segundos: " + d.Second);
            Console.WriteLine("----------------------------------------------");

            //nanosegundos:
            Console.WriteLine("11) nanosegundos: " + d.Ticks);
            Console.WriteLine("----------------------------------------------");
            //hora do dia:
            Console.WriteLine("12) hora do dia: " + d.TimeOfDay);
            Console.WriteLine("----------------------------------------------");

            //ano:
            Console.WriteLine("13) ano: " + d.Year);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("FORMATAÇÃO DATETIME:");

            /*FORMATAÇÃO DATETIME:*/

            //ToLongDateString:
            Console.WriteLine("Data longa: " + d.ToLongDateString());//convertendo datetime para string
            Console.WriteLine("----------------------------------------------");

            //ToLongTimeString:
            Console.WriteLine("Horario " + d.ToLongTimeString());
            Console.WriteLine("----------------------------------------------");

            //ToShortDateString:
            Console.WriteLine("Data curta: " + d.ToShortDateString());
            Console.WriteLine("----------------------------------------------");

            //ToShortTimeString:
            Console.WriteLine("Hora curta: " + d.ToShortTimeString());
            Console.WriteLine("----------------------------------------------");

            //ToString:
            Console.WriteLine("Data e hora " + d.ToString());
            Console.WriteLine("----------------------------------------------");

            //Mascara de formatação:
            Console.WriteLine("Data e hora com máscara de formatação " + d.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("----------------------------------------------");

            //Mascara de formatação com milisegundos:
            Console.WriteLine("Data e hora com máscara de formatação " + d.ToString("yyyy-MM-dd HH:mm:ss.fff"));
            Console.WriteLine("----------------------------------------------");

            /*OPERAÇÃOS COM DATETIME:
             * posso chamar operações que adicionem ou subtraiam valores do dateTime
             * muito usado, por exemplo para calcular uma data de vencimento.
             */

            Console.WriteLine("OPERAÇÃOS COM DATETIME:");
            Console.WriteLine("----------------------------------------------");

            //adicionar 2 horas na minha data inicial(d1):
            Console.WriteLine("data inicial: " + d);
            DateTime d2 = d.AddHours(2);
            Console.WriteLine("Adicionadas duas horas: " + d2);
            Console.WriteLine("----------------------------------------------");

            //adicionar minutos na minha data inicial(d1):
            Console.WriteLine("data inicial: " + d);
            DateTime dminutos = d.AddMinutes(3);
            Console.WriteLine("Adicionadas 3 minutos " + dminutos);
            Console.WriteLine("----------------------------------------------");

            //gerando um boleto com data de vencimento para 7 dias:

            //1-gerar a data do boleto, momento de emissão do boleto:

            DateTime boleto = DateTime.Now;//hora da emissão do boleto.

            //2-gerar a data de vencimento:

            DateTime boletovencimento = boleto.AddDays(7);
            Console.WriteLine("boleto emitido em: " + boleto);
            Console.WriteLine("vencimento do boleto: "+ boletovencimento);
            Console.WriteLine("----------------------------------------------");

            //diferença(subtração) entre datas:
            //obs.: se é diferença, tem haver com duração, ou seja: TimeSpan
            DateTime d3 = new DateTime(2000, 10, 15);
            DateTime d4 = new DateTime(2000, 10, 18);
            TimeSpan t = d4.Subtract(d3);
            Console.WriteLine("a diferença entre as datas é: " + t); 
            Console.WriteLine("----------------------------------------------");



        }

    }
}
