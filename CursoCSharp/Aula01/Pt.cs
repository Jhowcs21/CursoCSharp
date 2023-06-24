using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class Pt
    {
        public static void Main51()
        {
                   /* //Console.WriteLine("--------------------INICIO DO PRIMEIRO EXERCICIO--------------------");

                    Console.WriteLine("--------------------PRIMEIRO EXERCICIO--------------------");
            int idade;


            Console.WriteLine("Digite sua Idade");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else 
            {
                Console.WriteLine("Você é menor de idade!");
            }

            Console.WriteLine("--------------------FINAL DO PRIMEIRO EXERCICIO--------------------");
                                //Console.WriteLine("--------------------FINAL DO PRIMEIRO EXERCICIO--------------------");



                                //Console.WriteLine("--------------------INICIO DO SEGUNDO EXERCICIO--------------------");
            Console.WriteLine("--------------------INICIO DO SEGUNDO EXERCICIO--------------------");

            int numero;

            Console.WriteLine("Digite um numero");
            numero = int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else    
            {
                Console.WriteLine("Impar");
            }

                                //Console.WriteLine("--------------------FINAL DO SEGUNDO EXERCICIO--------------------");

                                //Console.WriteLine("--------------------INICIO DO TERCEIRO EXERCICIO--------------------");
                                Console.WriteLine("--------------------INICIO DO TERCEIRO EXERCICIO--------------------");

            int numero2;

            Console.WriteLine("Digite um numero");
            numero2 = int.Parse(Console.ReadLine());
            if (numero2 < 0)
            {
                Console.WriteLine("Numero digitado é negativo");
            }
            else if(numero2 >0)
            {
                Console.WriteLine("Numero digitado é positivo");
            }
            else
            {
                Console.WriteLine("O numero digitado foi zero!");
            }

                            Console.WriteLine("--------------------FINAL DO TERCEIRO EXERCICIO--------------------");
                            //Console.WriteLine("--------------------FINAL DO TERCEIRO EXERCICIO--------------------");



            
                             //Console.WriteLine("--------------------INICIO DO QUARTO EXERCICIO--------------------");
                            Console.WriteLine("--------------------INICIO DO QUARTO EXERCICIO--------------------");
            
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
            Console.WriteLine("O seu nome é " + nome);
            Console.WriteLine("o seu IMC É " + imc.ToString("F1"));
            if (imc >=18.5 && imc <=24.9)
            {
                Console.WriteLine("IMC está dentro do intervalo saudável");
            }
            else
            {
                Console.WriteLine("IMC está fora do intervalo de saude");
            }
            */
            




                            Console.WriteLine("--------------------FINAL DO QUARTO EXERCICIO--------------------");
                            //Console.WriteLine("--------------------FINAL DO QUARTO EXERCICIO--------------------");


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("--------------------INICIO DO QUINTO EXERCICIO--------------------");
            //Console.WriteLine("--------------------INICIO DO QUINTO EXERCICIO--------------------");

            String nomeDesc;
            double valor = 1000;
            double desc = 5.0 / 100;
            double desc2 = 10.0 / 100;
            double desc3 = 15.0 / 100;
            double desc4 = 20.0 / 100;
            double desc5 = 25.0 / 100;

            //calculo
            double conta = valor - (desc * valor);
            double conta2 = valor - (desc2 * valor);
            double conta3 = valor - (desc3 * valor);
            double conta4 = valor - (desc4 * valor);
            double conta5 = valor - (desc5 * valor);

            Console.WriteLine("Escolha o cupom");
            Console.WriteLine("\t1 - cumpom");
            Console.WriteLine("\t2 - cumpom");
            Console.WriteLine("\t3 - cumpom");
            Console.WriteLine("\t4 - cumpom");
            Console.WriteLine("\t5 - cumpom");
            Console.WriteLine("Qual o cupom?");
            
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Seu desconto foi: {desc} % de R${valor} = R${conta}");
                    break;
                case "2":
                    Console.WriteLine($"Seu desconto foi: {desc2} % de R${valor} = R${conta2}");
                    break;
                case "3":
                    Console.WriteLine($"Seu desconto foi: {desc3} % de R${valor} = R${conta3}");
                    break;
                case "4":
                    Console.WriteLine($"Seu desconto foi: {desc4} % de R${valor} = R${conta4}");
                    break; 
                case "5":
                    Console.WriteLine($"Seu desconto foi: {desc5} % de R${valor} = R${conta5}");
                    break;
                case "6":
                    Console.WriteLine($"Seu desconto não foi encontrado");
                    break;

                }
            Console.WriteLine("fim do programa");


            Console.WriteLine("--------------------FINAL DO QUINTO EXERCICIO--------------------");
            //Console.WriteLine("--------------------FINAL DO QUAINTO EXERCICIO--------------------");

        }
    }
}
