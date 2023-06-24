using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula01
{
    class While
    {
        public static void Main51()
        {


            /*
            Console.Write("Quer contar ate quanto?");
            int.TryParse(Console.ReadLine(), out int numUsuario);
            Console.Write("Qual vai ser o intervalo da contagem?");
            int.TryParse(Console.ReadLine(), out int numContagem);
            int contador = 0;

            while (contador <= numUsuario)
            {
                Console.WriteLine($"Contador: {contador} ");
                contador += numContagem;
                
            }
           


            Console.WriteLine("Adivinhe o numero!");
            int.TryParse(Console.ReadLine(), out int numUsuario);
            int numSorteado = 7;

            while (numUsuario != numSorteado)
            {
                Console.WriteLine($"Parabens!");
                int.TryParse(Console.ReadLine(), out numUsuario);
            }
            Console.WriteLine("Voce Errou");

             

            for (int i =0; i <= 100; i += 10)
            {
                Console.WriteLine($"Contador {i}");
            }
            */

           
            Console.WriteLine("Digite o numero!");
            int.TryParse(Console.ReadLine(), out int numero);
            
           
            for (int i = 0; i <= 10; i ++)
                
            {

                int resultado = numero * i;
                Console.WriteLine($"{numero} * {i} = {resultado}");
            }
            Console.WriteLine("Fim");
        }
    }
}
