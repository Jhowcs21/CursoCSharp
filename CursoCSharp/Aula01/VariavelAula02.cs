using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class VariavelAula02
    {
        public static void Main1()
        {
            /*
            int num1 = int.MaxValue;
            uint num2 = uint.MinValue;

            long num3 = long.MaxValue;
            ulong num4 = ulong.MaxValue;

            Console.WriteLine("O valor maximo é " + num1 + " O valor minimo é " + num2);
            Console.WriteLine("O valor maximo é " + num3 + " O valor minimo é " + num4);
            */


            string nome = "Jhow";
            string sobreNome = "Silva";
            int idade = 30;
            double nota = 8;
            double nota2 = 10;

            Console.WriteLine($"O aluno {nome + sobreNome} tem {idade} anos de idade, ele tirou {nota} na prova, teria tirado {nota2} se tive-se se esforçado!");

        }
    }
}
