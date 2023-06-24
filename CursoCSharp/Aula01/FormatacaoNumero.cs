using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class FormatacaoNumero
    {
        public static void Main6()
{
    Console .WriteLine("Quanto voce ganha por hora?");
    double valor = double.Parse(Console.ReadLine());
    double valorFinal = (valor * 8) * 24;
    Console .WriteLine(valor.ToString($" Vc ganha? {valorFinal.ToString("C0")} por mês"));


    double nota7 = 7;
    
}
    
    }
}
