using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class Media
    {

        public static void Main10()
        {
            Console.WriteLine("---------------------PRIMEIRA E SEGUNDA ATIVIDADE---------------------");

            Console.WriteLine();
            Console.WriteLine("Qual a primeira nota do aluno?");
        double m1 = double.Parse(Console.ReadLine());
            Console.WriteLine();
        Console.WriteLine("Qual a segunda nota do aluno?");
        double m2 = double.Parse(Console.ReadLine());
            Console.WriteLine();
        double mTotal = (m1 + m2) / 2;
        double sTotal = m1 + m2;
            //VE SE A MEDIA É MAIOR OU IGUAL AO TOTAL, SE SIM ELE RETORNA VERDADEIRO;
            bool passa = mTotal >= 7;


            // IMPRIMIR NA TELA OS RESULTADOS
        Console.WriteLine("A soma das medias dão " + sTotal);
        Console.WriteLine("A média do aluno " + mTotal);
        Console.WriteLine("O aluno foi aprovado? " + passa);

            Console.WriteLine();


            Console.WriteLine("---------------------TERCEIRA ATIVIDADE---------------------");
            
            //variaveis
            String nome;
            double peso, altura, imc;

            
            
            Console.WriteLine();


            Console.WriteLine("Digite seu Nome Completo");
             nome = (Console.ReadLine());
            Console.WriteLine("Digite seu peso");
             peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura");
             altura = double.Parse(Console.ReadLine());


            //calculo imc
            imc = peso / (altura * altura);

            Console.WriteLine("O seu nome é " + nome );
            Console.WriteLine("o seu IMC É " + imc.ToString("F1"));

            }
    

    }
}
