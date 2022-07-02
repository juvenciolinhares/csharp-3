using System;
using System.Globalization;

namespace datasEhoras

{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*exemplos DateTime:*/

            //tempo agora
            DateTime agora = DateTime.Now;
            Console.WriteLine("tempo de agora: " + agora);

            //ticks(tempo guardado pelo sistema que faz o calculo e converte em data e hora):
            Console.WriteLine(agora.Ticks);//imprime os nanosegundos
            Console.WriteLine("-------------------------------------------------------");
            //construtores do datetime:

            //ano, mes, dia(mais comum):
            DateTime d1 = new DateTime(2022, 07, 02);
            Console.WriteLine(d1);//além do ano imprime as horas zeradas
            Console.WriteLine("-------------------------------------------------------");

            //especificar um horário:
            DateTime d2 = new DateTime(2022, 07, 02, 18, 33, 50);
            Console.WriteLine(d2);//além do ano imprime as horas definidas
            Console.WriteLine("-------------------------------------------------------");

            //especificar um horário+ milisegundos:
            DateTime d3 = new DateTime(2022, 07, 02, 18, 33, 50, 500);
            Console.WriteLine(d3);//essa formatação não aceita os milisegundos
            Console.WriteLine("-------------------------------------------------------");

            /*UTILIZANDO OS BIULDERS*/
            //data atual
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);
            Console.WriteLine("-------------------------------------------------------");

            //data de hoje
            DateTime dataDeHoje = DateTime.Today;
            Console.WriteLine(dataDeHoje);//data de hoje + horário zerado
            Console.WriteLine("-------------------------------------------------------");

            //data de agora no greenwich(horário universal)
            DateTime dataNoGreeenwich = DateTime.UtcNow;
            Console.WriteLine(dataNoGreeenwich);//data no fuso horário greenwich
            Console.WriteLine("-------------------------------------------------------");

            /*UTILIZANDO O PARSE PRA GERAR DATAS*/
            //data para ser convertida de string para dateTime(ACEITA VÁRIOS FORMATOS)
            DateTime DataConversao = DateTime.Parse("2000-08-15");//formato utilizado por alguns bancos de dados
            DateTime DataConversaoComHorario = DateTime.Parse("2000-08-15 13:05:58");//data e hora
            Console.WriteLine(DataConversaoComHorario);
            Console.WriteLine("-------------------------------------------------------");

            //digitando no formato brasileiro:
            DateTime DataFormatoBrasil = DateTime.Parse("2000/08/15");//separada por barras
            DateTime DataFormatoBrasilComHorario = DateTime.Parse("2000/08/15 13:05:58");//data e hora
            Console.WriteLine(DataFormatoBrasil);
            Console.WriteLine(DataFormatoBrasilComHorario);
            Console.WriteLine("-------------------------------------------------------");

            /*UTILIZANDO O PARSE EXACT => Eu determino o formato*/
            //indico a data, depois uma mascara especificando ano, dia, mes, uso o cultureinfo.invariantculture
            DateTime dateParseExact = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(dateParseExact);
            Console.WriteLine("-------------------------------------------------------");

            //outro exemplo:
            DateTime dateParseExactOutroExemplo = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);
            Console.WriteLine(dateParseExactOutroExemplo);
            Console.WriteLine("-------------------------------------------------------");



        }
    }
}
/*
 * REPRESENTA UM INSTANTE
 * serve pra guardar data ou data e horário
 * é do tipo struct(tipo valor em c#)
 * 
 * REPRESENTAÇÃO INTERNA:
 * armazena um numero de ticks(100 nanosegundos) desde a meia noite do dia 1/1/da era comum
 */
