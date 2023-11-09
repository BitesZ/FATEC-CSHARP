using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_4
{
    class Program
    {
        static void Main(string[] args)
        {//INICIO
            INICIO:
            Console.Title = "Atividade 7";
            Console.Write("Digite um número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Este número é negativo.");
                Console.ResetColor();
            }
            else if (num == 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Este número é zero.");
                Console.ResetColor();
            }
            else if (num > 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Este número é positivo.");
                Console.ResetColor();
            }
            Console.WriteLine("Pressione qualquer tecla para continuar o programa ou feche o programa.");
            Console.ReadKey();
            Console.Clear();
            goto INICIO;
        }//FIM
    }
}
