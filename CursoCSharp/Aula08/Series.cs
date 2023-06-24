using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula08
{
    class Series
    {
       public string Nome;
        public string Genero;
        public int Lanca;
        public int Classif;

        public Series(string nome, string genero, int lanca, int classif) 
        {
            Nome = nome;
            Genero = genero;
            Lanca = lanca;
            Classif = classif;
        }

        public Series()
        { 
        }
            
    }


    class Serie
    {
        public static void Main5441()

        {

            //Construtor Padrão
            Series ApresentarSerie = new Series()
            {
                Nome = "Game Of Tronos",
                Genero = "Aventura",
                Lanca = 2011,
                Classif = 18,
            };

            Series ApresentarSerie2 = new Series()
            {
                Nome = "CDZ",
                Genero = "Anime",
                Lanca = 2011,
                Classif = 18,
            };


            Series ApresentacaoSerie3 = new Series("Bleach", "Anime", 2011, 18);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Nome:{ApresentarSerie.Nome}");
            Console.WriteLine($"Genero:{ApresentarSerie.Genero}");
            Console.WriteLine($"Lançamento:{ApresentarSerie.Lanca}");
            Console.WriteLine($"Classificação:{ApresentarSerie.Classif}");
            Console.WriteLine("");
            
            Console.WriteLine($"Nome:{ApresentarSerie2.Nome}");
            Console.WriteLine($"Genero:{ApresentarSerie2.Genero}");
            Console.WriteLine($"Lançamento:{ApresentarSerie2.Lanca}");
            Console.WriteLine($"Classificação:{ApresentarSerie2.Classif}");
            Console.WriteLine("");  
            Console.WriteLine($"Nome:{ApresentacaoSerie3.Nome}");
            Console.WriteLine($"Genero:{ApresentacaoSerie3.Genero}");
            Console.WriteLine($"Lançamento:{ApresentacaoSerie3.Lanca}");
            Console.WriteLine($"Classificação:{ApresentacaoSerie3.Classif}");
            Console.WriteLine("TOP DE MAIS");
            Console.WriteLine("");


        }
    }
}
