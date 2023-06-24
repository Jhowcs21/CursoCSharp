using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class Comentarios
    {
        public static void Main2()
        {
            /*Console.WriteLine();
            Console.WriteLine("Olá");
            Console.WriteLine("Jonatha");
            */

            //Declarando variaveis

            var nome = "Daniel";
            Console.WriteLine("Qual seu nome?");
            Console.WriteLine(nome);
            Console.WriteLine();


            double sal = 4500.58;
            Console.WriteLine("Salario R$:" + sal);
            Console.WriteLine();

            //sempre que for usar o float colocar o "F" no final, mas corre o risco de perder dados 
            float sal2 = 450.58f;
            Console.WriteLine("Usando o float R$:" + sal2);
            Console.WriteLine();

            Console.WriteLine("De lei né!");
            string olaMundo = "Olá Mundo!";
            Console.WriteLine(olaMundo);
            Console.WriteLine();

            int idade = 57;
            Console.WriteLine("Qual sua idade? ");
            Console.WriteLine(idade);
            Console.WriteLine();

            // Verdadeiro E Falso
            bool prai = false;
            Console.WriteLine("Você vai para a praia?");
            Console.WriteLine(prai);
               
            
        } 
        
        
    }
}
