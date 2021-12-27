﻿using System;

namespace Alunos
{
    class Program
    {   
        static void Main(String[] args)
        {
            string? opcaoUsuario = obterOpcaoUsuario();

            while (opcaoUsuario?.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        break;
                    case "2":
                        //TODO: inserir aluno
                        break;
                    case "3":
                        //TODO: calcular média
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = obterOpcaoUsuario();
            }
        }

        private static string? obterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();


            string? opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}