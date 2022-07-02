using System;

namespace funcoesStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG    ";

            //converter para maiúsculo:
            string tudoMaiusculo = original.ToUpper();

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + tudoMaiusculo + "-");
            Console.WriteLine("------------------------------------");

            //converter para minusculo:
            string tudoMinusculo = original.ToLower();

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToLower: -" + tudoMinusculo + "-");
            Console.WriteLine("------------------------------------");

            //Função TRIM:
            //apaga os espa~ços em branco no inicio e final
            string funcaoTrim = original.Trim();

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("funcaoTrim: -" + funcaoTrim + "-");
            Console.WriteLine("------------------------------------");

            //funcao de procura primeiro:
            int procura = original.IndexOf("bc");//retorna um inteiro

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("procura: -" + procura + "-");
            Console.WriteLine("------------------------------------");

            //funcao de procura ultimo:
            int procuraUltimo = original.LastIndexOf("bc");//retorna um inteiro

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("procuraUltimo: -" + procuraUltimo + "-");
            Console.WriteLine("------------------------------------");

            //recortar uma string:
            string recorte1 = original.Substring(3);// define apenas um índice
            string recorte2 = original.Substring(3, 5);// define um índice e a quantidade de caracteres da substring
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("recorte1(define apenas um índice): -" + recorte1 + "-");
            Console.WriteLine("recorte2(define um índice e a quantidade de caracteres da substring):-" + recorte2 + "-");
            Console.WriteLine("------------------------------------");

            //substituir uma parte de uma string por outra:
            string substituirChar = original.Replace('a', 'x');//substituir o a por x
            string substituirString = original.Replace("abc", "xy");//substituir o abc por xy
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("substituir o a por x: -" + substituirChar + "-");
            Console.WriteLine("substituir o abc por xy: -" + substituirString + "-");
            Console.WriteLine("------------------------------------");

            //testar se a string está vazia(útil em cadastros e formulários):
            bool testeVazia = string.IsNullOrEmpty(original);//testa se o conteúdo é nulo ou vazio

            Console.WriteLine("teste Vazia: " + testeVazia);
            Console.WriteLine("------------------------------------");

            //testar se a string está vazia ou então é um espaço em branco:
            bool testeEspacoEmBranco = string.IsNullOrWhiteSpace(original);//testa se o conteúdo é nulo ou espaço em branco

            Console.WriteLine("teste Espaco Em Branco: " + testeEspacoEmBranco);
            Console.WriteLine("------------------------------------");

            /*
             * além dessas tem as ja usadas:
             * .split: recorta com base num caracter
             * .parse: converte string para num
             * .Convert.Toint32(str): mesma função
             * .ToString : numero para string
             * .ToString () com parametro de formatação: ex.: .ToString("F2")
             */

        }
    }
}
