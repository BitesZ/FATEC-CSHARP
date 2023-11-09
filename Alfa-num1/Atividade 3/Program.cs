using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            string nome, pri_nome, sob_nome, nome_cor, nome_sub;
            int pos, cos;
            Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();
            pos = nome.IndexOf(" ");
            cos = nome.IndexOf("T");
            pri_nome = nome.Substring(0, pos);
            sob_nome = nome.Substring(cos);
            nome_cor = nome.Substring(5, 10);
            nome_sub = nome.Replace("a", "o");
            Console.WriteLine("Seu primeiro nome: " + pri_nome);
            Console.WriteLine("Seu sobrenome: " + sob_nome);
            Console.WriteLine("Conteúdo da String do caractere cinco ao dez: " + nome_cor);
            Console.WriteLine("Seu nome com os caracteres a substituido pelo o: " + nome_sub);
            Console.ReadKey();
        }
    }
}
