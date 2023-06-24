using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class Parte02
    {
        public static void Main2()
        {
            Console.WriteLine("Digite seu nome?");
            string nome =  Console.ReadLine();

            Console.WriteLine("Digite o sobrenome");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());



            Console.WriteLine("Vamos fazer uma conta?");
            //Primeiro numero
            Console.WriteLine("Digite o primeiro numero!");
            int num1 = int.Parse(Console.ReadLine());
           
         
            //Segundo numero 
            Console.WriteLine("Digite o segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            //codigo para o sinal
            

            //Codigo para conta
            int conta = num1 + num2;
            

            

            /*
            Console.WriteLine("Qual o seu Objetivo Salarial?");
            double salario = double.Parse(Console.ReadLine());
            */

            
            
            
            
            

          Console.WriteLine($"Verifique os dados: nome: {nome} Sobrenome:{sobrenome} Idade:{idade} Conta:{conta}");
        }
    }
}
