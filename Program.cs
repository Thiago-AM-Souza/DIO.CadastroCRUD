﻿using System;
using DIO.Cadastro.Interfaces;

namespace DIO.Cadastro
{
    class Program
    {

        static void Main(string[] args)
        {          
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Menu.InserirPessoa();
                        break;
                    case "2":
                        Menu.ListarPessoas();
                        break;
                    case "3":
                        Menu.AtualizarPessoa();
                        break;
                    case "4":
                        Menu.ExcluirPessoa();
                        break;
                    case "5":
                        Menu.VisualizarPessoa();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            Console.WriteLine("Obrigado por se cadastrar em meu programa.");
            Console.WriteLine();
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Bootcamp Cadastro");
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");

            Console.WriteLine("1 - Inserir novo cadastro");
            Console.WriteLine("2 - Listar pessoas cadastradas");           
            Console.WriteLine("3 - Atualizar cadastro");
            Console.WriteLine("4 - Excluir cadastro");
            Console.WriteLine("5 - Visualizar cadastro");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

        
    }
}