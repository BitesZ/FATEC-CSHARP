using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {//INICIO
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double Soma = num1 + num2;
            double Subtração = num1 - num2;
            double Divisão = num1 / num2;
            double Multiplicação = num1 * num2;
            Console.WriteLine("Resultado da Soma: " + Soma);
            Console.WriteLine("Resultado da Subtração: " + Subtração);
            Console.WriteLine("Resultado da Divisão: " + Divisão);
            Console.WriteLine("Resultado da Multiplicação: " + Multiplicação);
            Console.ReadKey();

        }//FIM
    }
}
