using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula07
{
    class ExercicioMetodosComRetorno
    {
        public double Real;
        public double Dolar;
        public double Euro;
      
      
    }
    class Comeco
    {
        public static void Main5154541()
        {
            ExercicioMetodosComRetorno dinheiro = new ExercicioMetodosComRetorno()
            {
                Dolar = 0.21,
                Real = 1,
            };
            
            Console.WriteLine($"");
            Console.WriteLine("Digite o valor em BRL para a conversão em Dolar:");

            double Real = double.Parse(Console.ReadLine());

            // calculo para conversão 
            double cv = Real * 0.21;
            Console.WriteLine($" O Valor convertido para o Dolar é de:{cv}");
        }
    }
}
