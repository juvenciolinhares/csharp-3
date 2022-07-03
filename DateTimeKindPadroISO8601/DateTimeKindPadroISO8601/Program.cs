using System;

namespace DateTimeKindPadroISO8601
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boa prática: armazenar no utc e intanciar no horário local:
            DateTime datalocal = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime datautc = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime data = new DateTime(2000, 8, 15, 13, 5, 58);
            //quando imprimir não acontece nada:

            
            Console.WriteLine("data local: " + datalocal);
            Console.WriteLine("data utc: " + datautc);
            Console.WriteLine("Data não especificada: " + data);
            Console.WriteLine("-----------------------------------------------------------------");

            //funções com  DateTime datalocal ... DateTimeKind.Local);
            Console.WriteLine("data local Kind: " + datalocal.Kind);
            Console.WriteLine("data local: " + datalocal);
            Console.WriteLine("data local fuso horario local: " + datalocal.ToLocalTime());
            Console.WriteLine("data local utc: " + datalocal.ToUniversalTime());

            Console.WriteLine("-----------------------------------------------------------------");

            //funções com  DateTime datautc ...DateTimeKind.Utc);
           
            Console.WriteLine("data utc kind:" + datautc.Kind);
            Console.WriteLine("data utc:" + datautc);
            Console.WriteLine("data utc pra local:" + datautc.ToLocalTime());
            Console.WriteLine("data utc para utc:" + datautc.ToUniversalTime());
            Console.WriteLine("-----------------------------------------------------------------");


            //funções com  DateTime datanao especificada
        
            Console.WriteLine("data kind:" + data.Kind);
            Console.WriteLine("data:" + data);
            Console.WriteLine("data para data local:" + data.ToLocalTime());
            Console.WriteLine("data para utc:" + data.ToUniversalTime());

            /*PADRÃO ISO 8601
             * 
             * formato: yyyy-MM-ddTHH:mm:ssZ
             * o Z indica que a data/hora está armazenada em string no padrao UTC
             */

            // data com formatação pessoal:
            DateTime dataMinhaFormatacao = DateTime.Parse("2000-08-15 13:05:58");
            Console.WriteLine("data com formatação aleatória: "+ dataMinhaFormatacao);

            //data com formatação ISO 8601:
            //aplicando as boas práticas: data armazenada: formato UTC, data instanciada: fotmato LOCAL
            DateTime dataISO = DateTime.Parse("2000-08-15T13:05:58Z");// formato do utc(fuso horário)
            Console.WriteLine("data com formatação ISO 8601: " + dataISO);// formato do LOCAL(fuso horário do sistema)
            
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("data formatação aleatória tipo(kind):" + dataMinhaFormatacao.Kind);
            Console.WriteLine("data formatação aleatória:" + dataMinhaFormatacao);
            Console.WriteLine("data formatação aleatória para data local:" + dataMinhaFormatacao.ToLocalTime());
            Console.WriteLine("data formatação aleatória para utc:" + dataMinhaFormatacao.ToUniversalTime());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("data ISO tipo(kind):" + dataISO.Kind);
            Console.WriteLine("data ISO:" + dataISO);
            Console.WriteLine("data ISO para data local:" + dataISO.ToLocalTime());
            Console.WriteLine("data ISO para utc:" + dataISO.ToUniversalTime());

            Console.WriteLine("----------------------------------------------------");

           
            
            /*obs.: se eu não usar o ToUniversalTime antes de converter para string
             * a hora vai ser impressa como local, logo, antes de converter,
             * preciso chamar o toUniversalTime().
             */
            Console.WriteLine(dataISO.ToString("yyyy-MM-ddTHH:mm:ssz"));// cuidado!: resultado: 2000-08-15T 10:05:58-3
            Console.WriteLine(dataISO.ToUniversalTime().ToString("yyy-MM-ddTHH:mm:ssz"));// resultado: 2000-08-15T 13:05:58+0




        }
    }
}
/*
 * DateTimeKind
 * define 3 valores possivei pra localidade da data:
 * 1- Local(fuso do sistema, exemplo: sao paulo= gmt -3)
 * 2- utc: fuso horario gmt
 * 3- unspecified: não especificado
 */
