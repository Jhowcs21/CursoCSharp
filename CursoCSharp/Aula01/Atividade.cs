using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class Atividade
    {
        public static void Main5()
        {
            Console.WriteLine("Digite o primeiro numero!");
           int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            int soma = num1 + num2;
            

            Console.WriteLine("o RESULTADO FOI" + soma );

        }
    }
}
