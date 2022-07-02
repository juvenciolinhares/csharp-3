using System;

namespace switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x)
            {
                case 1:
                    day = "sunday";
                    break;

                case 2:
                    day = "monday";
                    break;

                case 3:
                    day = "tuesday";
                    break;
                case 4:
                    day = "wednesday";
                        break;
                case 5:
                    day = "thurdsday";
                    break;
                case 6:
                    day = "saturday";
                    break;
                case 7:
                    day = "saturday";
                    break;
                default:
                    day = "Invalid value";
                    break;


            }
            Console.WriteLine("Day: " +day);
        }
    }
}
/*
 * ESTRUTURA OPCIONAL AO IF-ELSE
 * quando envolve teste do valor de uma variavel
 */
