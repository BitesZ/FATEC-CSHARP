using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {//Inicio
            Console.WriteLine("Qual a Altura do Retângulo");
            double Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a Base do Retângulo");
            double Base = Convert.ToDouble(Console.ReadLine());
            double Dimensão = Altura / Base;
            Console.WriteLine("A Altura é: " + Altura + " e sua Base é: " + Base + " portanto sua Dimensão é: " + Dimensão);
            Console.ReadKey();
        }//Fim
    }
}
