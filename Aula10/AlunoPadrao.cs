using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula10
{
    class AlunoPadrao
    {
        protected string Nome;
        protected string Curso;
        protected int Ra;

        protected void AcessandoValores()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"R.A: {Ra}");
        }
    }

}
