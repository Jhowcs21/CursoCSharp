using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula09
{
    class GetESet
    {
        private string Nome;
        private int Idade;
       

        public GetESet(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public GetESet()
        {

        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
            
        public int GetIdade()
        {

            return Idade = Math.Abs(Idade);
        }

        public void SetIdade(int idade)
        {

            Idade = Math.Abs(Idade);
            Idade = idade;
            
        }


        class obj
        {
            public static void Main()
            {
                GetESet pessoal = new GetESet("Jonatha", -30);
                Console.WriteLine(pessoal.GetNome());
                Console.WriteLine(pessoal.GetIdade());

                var Pessoa02 = new GetESet();
                Pessoa02.SetNome("Joao");
                Pessoa02.SetIdade(-22);
                Console.WriteLine(Pessoa02.GetNome());
                Console.WriteLine(Pessoa02.GetIdade());
            }
        }

    }
}
