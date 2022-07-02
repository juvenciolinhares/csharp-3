using System;

namespace InterferenciasDeTiposPalavraVar
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var x = 10;//o compilador entende que é um inteiro
            var y = 20.0;
            var z = "Maria";
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
/*
 * PALAVRA VAR:
 * entra no lugar do tipo:
 * 
 */
