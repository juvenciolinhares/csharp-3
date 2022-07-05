using System;
using System.Collections.Generic;
using System.Text;//string builder

namespace composicaoPratica2.Entites
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comments> Comments { get; set; } = new List <Comments>();//composição classes Post + comments

        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        /*obs.: embora o diagrama de classe não tenha especificado os métodos add e remove comment,
         * eles precisa ser criado(isso é padrão)
         * */
        public void AddComment(Comments comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comments comment)
        {
            Comments.Remove(comment);
        }

        //Usar o string builder:
        /*operações mais usadas:
         * append(adicionar um texto no fim do stringbuilder)
         * appendLine: adiciona texto e coloca uma quebra de linha
         */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();// importar System.Text
  
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));//máscara de formatação
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
           
            //para adicionar os comentários, preciso percorrer a lista e adicionar cada um deles no stringbuilder:
            foreach(Comments c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();

        }
    }

    
}
