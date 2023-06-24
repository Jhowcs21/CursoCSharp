using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula08
{
    class AtributosStaticos
    {

        public double a;
        public double b;

        public double Somar(double a, double b)
        {
            return a + b;
        } 

        public double Sub(double a, double b)
        {
            return a - b;
        }
    }

    class AcAtributos
    {
        public static void Main51484()
        {

                    AtributosStaticos SomaSimples = new AtributosStaticos();
                    Console.WriteLine(SomaSimples.Somar(3,4));
                
                    AtributosStaticos SubSimples = new AtributosStaticos();
                    Console.WriteLine(SubSimples.Sub(5, 4));
        
        }
    }
}
