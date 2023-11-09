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
        {//inicio
            string nome, sobrenome, nome_i, nome_p;
            int pos, cos;
            Console.WriteLine("Bem vindo ao gerador de e-mails fatec");
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            pos = nome.LastIndexOf(" ");
            nome_i = nome.Substring(pos).ToLower().Trim();
            cos = nome.IndexOf(" ");
            nome_p = nome.Substring(0, cos).ToLower();
            Console.WriteLine("Primeiro nome: " + nome_p);
            Console.WriteLine("Sobrenome:" + nome_i);
            Console.WriteLine("Seu email institucional é: " + nome_p +"."+ nome_i + "@fatec.sp.gov.br");
            Console.ReadKey();
        }//fim
    }
}
