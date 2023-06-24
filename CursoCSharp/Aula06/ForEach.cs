using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula6
{
    class ForEach
    {
        public static void Main6454()
        {
            /*int [] numero = new int [4]{3,4,5,6};
            Console.WriteLine($"Mostrando o array numero: {numero [2]}");


            string[] nome = new string[4]  ;
            Console.WriteLine();

            nome[0] = "Jonatha";
            nome[1] = "Alan";
            nome[2] = "Marcos";
            nome[3] = "Gustavo";

            Console.WriteLine($"Mostrando o array numero: {nome[1]}");

            string[] nome = new string[4] { "Jonatha", "Alan", "Marcos", "Gustavo" };
            //var nome = "Gabriel";
            foreach (string aluno in nome)
            {
                Console.WriteLine(aluno);
            */



            Console.WriteLine("<-------------Exercicios---------------->");

            int contador = 0;

            while (contador <= 9)
            {
                contador++;
                Console.WriteLine($" {contador}");

            }

            Console.WriteLine("FINAL DO EXERCICO 1 ");

            Console.WriteLine("Inicio DO EXERCICO 2 ");


            for (int cont = 0; cont <= 20; cont += 2)
            {
                Console.WriteLine(cont);

            }

            Console.WriteLine("FINAL DO EXERCICO 2 ");

            Console.WriteLine("Inicio DO EXERCICO 3 ");

            int numero2;

            Console.WriteLine("Digite um numero");
            numero2 = int.Parse(Console.ReadLine());

            while (numero2 != 0)
            {
                Console.WriteLine("Continue digitando");
                numero2 = int.Parse(Console.ReadLine());
            }

            {
                Console.WriteLine("vc chegou no final");
            }

            Console.WriteLine("FINAL DO EXERCICO 3 ");
            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("INCIO DO EXERCICO 4 ");

            string[] cidades = new string[] { "Mauá", "Santo André", "Ribeirão Pires", "São Paulo", "São jose dos Campos" };

            foreach (string aluno in cidades)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine("FINAL DO EXERCICO 4 ");
            Console.WriteLine();
            Console.WriteLine();


            /*Console.WriteLine("INICIO DO EXERCICO 5 ");
            
            Console.WriteLine("Digite um numero");
            int num;
            num = int.Parse(Console.ReadLine());
            do(num == num)
            {
                
            }
            */

        }
        
    }
}
