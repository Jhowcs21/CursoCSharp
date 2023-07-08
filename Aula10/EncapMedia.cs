using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Aula10
{
    class EncapMedia
    {
        private double Nota01;
        private double Nota02;
        private double Media;
        /*
        public double Nota011 { get => Nota01; set => Nota01 = value; }
        public double Nota021 { get => Nota02; set => Nota02 = value; }
        public double Media { get => media; set => media = value; }*/

        private double CalMediaAluno()
        {
            Media = (Nota01 + Nota02) / 2;
            return Media;
        }

        public void Mensgame()
        {
            Console.Write($"Digite sua 1ª nota: ");
            double.TryParse(Console.ReadLine(), out Nota01);

            Console.Write($"Digite sua 2ª nota: ");
            double.TryParse(Console.ReadLine(), out Nota02);

            Console.WriteLine($"Sua média é: {CalMediaAluno()}");
        }
    }

    class Aluno 
    {
       public static void Main1544() 
        {
            EncapMedia Aluno01 = new EncapMedia();
            Aluno01.Mensgame();
        }
    }
}
