using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {//INICIO
            Console.WriteLine("Digite o primeiro número:");
            Double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            Double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            Double num3 = Convert.ToDouble(Console.ReadLine());
            Double numeros = num1 + num2 + num3;
            Double Divisão = numeros / 3;
            Console.WriteLine("Resultado é aritmetico dos numeros é: " + Divisão);
            Console.ReadKey();
        }//FIM
    }
}
