using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {//INICIO
            Console.WriteLine("Digite um número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1--);
            Console.WriteLine("O valor antecessor a este é: " + num1);
            Console.ReadKey();
        }//FIM
    }
}
