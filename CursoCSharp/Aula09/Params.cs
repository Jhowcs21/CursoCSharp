using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula09
{
    internal class Params
    {
        /*
        public static void Apresentar(params string[] alunos)
        {
            foreach(string aluno in alunos)
            {
                Console.WriteLine($"Olá, {aluno}! Bom dia!");
            }
        }
        public static void Main()
        {
            Apresentar("Jonatha", "Gabriel", "Gabriel2", "Nathalia", "Ligia");
        */
        public static void Apresentar(params string[] marcas)
        {
            foreach(string marca in marcas)
            {
                Console.WriteLine($"A marca: {marca}, é uma das suas favoritas");
            }
        }

        public static void Main241574()
        {
            Apresentar($"Lacoste", "Nike", "Mizuno", "Oakley");
        }
        
    }
}
