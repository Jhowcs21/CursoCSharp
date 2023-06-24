using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula07
{
    class Aulapt2
    {
        public string Modelo;
        public string Marca;
        public int Ano;
        public double Valor;
    }

    class Exemplor01 
    { 
        public static void Main51487712() 
        {
            Aulapt2 Carro01 = new Aulapt2
            {
                Modelo = "Fox",
                Marca = "VW",
                Ano = 2010,
                Valor = 28000.00,
            };
            Console.WriteLine($"Modelo: {Carro01.Modelo}");
                
        }
    }
}
