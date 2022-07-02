using System;
using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*sintaxe:
             * (condicao)? valor se verdadeiro : valor se falso;
             */
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(desconto);

        }
    }
}
/*
 * ESTRUTURA OPCIONAL AO IF-ELSE
 * quando se deseja decidir um valor com base em uma condição.
 * sintaxe:
 * (condicao)? valor se verdadeiro : valor se falso;
 */
