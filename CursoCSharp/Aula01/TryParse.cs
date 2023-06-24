using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class TryParse
    {
        public static void Main95()
        {

            
            Console.WriteLine("Qual a primeira nota do aluno?");
            double nota1;
            double.TryParse(Console.ReadLine(), out nota1);
            Console.WriteLine();
            Console.Write("Digite a segunda nota do aluno:");
            double nota2;
            double.TryParse(Console.ReadLine(), out  nota2);
            
            //Calculo media
            double media = (nota1 + nota2) / 2;
            Console.WriteLine($"A media do aluno foi: {media}");

            if (media >= 7)
            {
                Console.WriteLine($"Esse aluno foi aprovado com a media {media}");
            }
            else if (media >= 6)
            {
                Console.WriteLine($"Esse aluno foi aprovado pelo conselho com a media {media}");
            }
            else if (media < 6)
            {
                Console.WriteLine($"Esse aluno foi reprovado com a media {media}");
            }
            else 
            {
                Console.WriteLine($"Reveja as notas digitadas");
            }

            Console.WriteLine("Final do programa");
            

            

        }
    }
}
