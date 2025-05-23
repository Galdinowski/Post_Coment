using System;
using Menu.Entities;

namespace Menu
{

    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new("Jogo do Sao Paulo hoje?");
            Comment c2 = new Comment("Luciano em campo? ");
            Post p1 = new Post(
                DateTime.Parse("11/05/2025 17:59:44"),
                "Jogo contra o Santos de Neymar (SPFC X SANTOS)",
                "Sao Paulo favorito",
                100
            );

            p1.AddComment(c1);
            p1.AddComment(c2);



            Comment c3 = new("Ancelotti diz sim a Ryan Francisco");
            Comment c4 = new Comment("Ryan agora vai? ");
            Post p2 = new(
                DateTime.Parse("04/05/2025 08:59:44"),
                "Ancelotti ira convocar Ryan Francisco?",
                "Novo Ronaldo de Cotia na Selecao",
                185
            );

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
         }

    }
}