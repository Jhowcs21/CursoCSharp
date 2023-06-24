using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula07
{
    class Aula7
    {
        public string nome;
        public int dataLanc;
        public double preco;

        public string Apresentar()
        {

            return string.Format($"Olá, {nome}");
        }

        public void Apresentar2()
        {
            Console.WriteLine(Apresentar());
            
            
        }
    
    }

    class Utilizando
    {
    
        public static void Main515451()
        {
            Aula7 aula7 = new Aula7
            {
                nome = "Dragons Dogma II",
                dataLanc = 2023,
                preco = 500,
           
        };
            //Console.WriteLine($"Nome: {aula7.nome}");
            //Console.WriteLine($"Data de Lançamento: {aula7.dataLanc}");
            //Console.WriteLine($"Valor: {aula7.preco}");
            Console.WriteLine("");
           // Console.WriteLine($"Nome no apresentar {aula7.Apresentar2()}");
            Console.WriteLine($"Nome no apresentar {aula7.Apresentar()}");
        }


    }
}
