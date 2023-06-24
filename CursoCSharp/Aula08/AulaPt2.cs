using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula08 
{
    class AulaPt2
    {
        public string NomeProd;
        public double Preco;
        public int Ano;
        public static double Desc;

        public AulaPt2(string nomeProd, double preco, int ano)
        {
            NomeProd = nomeProd;
            Preco = preco;
            Ano = ano;
        }

        public AulaPt2()
        {

        }

        public double CalcValor()
        {
            double ValoComDesconto = Preco - (Preco * Desc);
            return ValoComDesconto;
        }
    }

    class Carro
    {
        public static void Main() 
        {
            AulaPt2 Carro01 = new AulaPt2("Fox", 20000, 2010);
            AulaPt2.Desc = 0.1;
            Console.WriteLine($"Nome: {Carro01.NomeProd}");
            Console.WriteLine($"Valor: R$ {Carro01.Preco}");
            Console.WriteLine($"Ano: {Carro01.Ano}");
            Console.WriteLine($"Desconto: {Carro01.CalcValor()}");

            Console.WriteLine("---------------------");

            AulaPt2 Carro02 = new AulaPt2("Civic",244.900, 2023);
            AulaPt2.Desc = 0.25;
            Console.WriteLine($"Nome: {Carro02.NomeProd}");
            Console.WriteLine($"Valor: R$ {Carro02.Preco}");
            Console.WriteLine($"Ano: {Carro02.Ano}");
            Console.WriteLine($"Desconto: {Carro02.CalcValor()}");


        }
    }
}
