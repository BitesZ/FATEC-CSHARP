using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_5
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            string nome, nome_e;
            int pos;
            Console.WriteLine("Bem vindo ao gerador de e-mails fatec");
            Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();
            pos = nome.IndexOf(" ");
            nome_e = nome.Substring(0, pos);
            Console.WriteLine("Seu email institucional é: " + nome_e + "@fatec.sp.gov.br");
            Console.ReadKey();
        }//fim
    }
}
