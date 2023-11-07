using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VerificadorSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie um programa que o usuário informe uma senha, depois
             * de informar a senha o sistema deve validar se a senha tem
             * mais de 8 caracteres, uma letra maiuscula, uma letra minuscula
             * e um numero. Ao final informar se é valida ou não.
            */

            // 1 - Solicitar a senha
            Console.WriteLine("Qual a senha a ser validada?");

            string senha = Console.ReadLine();
            bool senhaValida = true;

            // 2 - Verificar se tem mais de 8 caracteres
            if (senha.Length < 8)
            {
                Console.WriteLine("A senha precisa de no minimo 8 caracteres");
                senhaValida = false;
            }

            // 3 - Verificar se tem uma letra maiuscula
            if (!senha.Any(char.IsUpper))
            {
                Console.WriteLine("A senha precisa de um caracter maiusculo");
                senhaValida = false;
            }

            // 4 - Verificar sem tem uma letra minúscula
            if (!senha.Any(char.IsLower))
            {
                Console.WriteLine("A senha precisa de um caracter minusculo");
                senhaValida = false;
            }

            // 5 - Verificar se tem um número

            /*
                Regex regex = new Regex(@"\d");
                if (!regex.IsMatch(senha))
                {
                    Console.WriteLine("A senha precisa de um digito");
                }
            */

            if (!senha.Any(char.IsDigit))
            {
                Console.WriteLine("A senha precisa conter ao menos um numero");
                senhaValida = false;
            }

            if (senhaValida)
                Console.WriteLine("A senha é valida!");
            else
                Console.WriteLine("A senha não é valida!");

            Console.ReadKey();
        }
    }
}
