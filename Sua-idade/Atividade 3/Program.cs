using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {//INICIO
            Console.WriteLine("Qual o ano de seu nascimento?");
            Double ano_nasc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o ano Atual?");
            Double ano_atual = Convert.ToDouble(Console.ReadLine());
            Double idade = ano_atual - ano_nasc;
            Console.WriteLine("Sua idade é: " + idade);
            Console.ReadKey();
        }//FIM
    }
}
