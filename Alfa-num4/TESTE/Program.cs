using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TESTE
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome, nome_p;
            int pos, cos;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            pos = nome.IndexOf("R");
            nome_p = nome.Substring(0, pos);
            Console.WriteLine(nome_p);
            Console.ReadKey();
        }
    }
}
