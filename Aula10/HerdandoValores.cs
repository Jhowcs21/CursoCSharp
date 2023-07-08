using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula10
{
    class HerdandoValores : AlunoPadrao
    {
        protected string ModCurso;
        //A - Curso Livre
        //B - Graduação
        //C - MBA - Pós-Graduação

        public void Msg() 
        {
            Console.WriteLine($"Modalidade do Curso:" +
                $" {ModCurso}");
        }

        public HerdandoValores(string nome, string curso, int ra, string modcurso)
        {
            {
                Nome = nome;
                Curso = curso;
                Ra = ra;
                ModCurso = modcurso;
                AcessandoValores();
            }
        }

        class TesteAluno
        {
            public static void Main()
            {
                HerdandoValores Aluno01 = new HerdandoValores("João", "C#", 2424, "A");
                Aluno01.Msg();
            }
        }
    }
}
