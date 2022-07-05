using composicaoPratica2.Entites;
using System;

namespace composicaoPratica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1º POST*/

            //instancio ja com os argumentos
            Comments comment1 = new Comments("Have a nice trip");
            Comments comment2 = new Comments("Wow that's awesome!");

            //instancio com os construtores
            Post post1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderfulkcountry!",
                12);

            //adicionar os comentários c1 e c2:
            post1.AddComment(comment1);
            post1.AddComment(comment2);

            /*2º POST*/

            //comentarios:
            Comments comment3 = new Comments("Good Night");
            Comments comment4 = new Comments("May the Force be whit you");

            //post:
            Post post2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            //adicionar comentários ao post:
            post2.AddComment(comment3);
            post2.AddComment(comment4);

            Console.WriteLine(post1);
            Console.WriteLine(post2);


        }
    }
}
