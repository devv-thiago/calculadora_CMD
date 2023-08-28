global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;

internal class Program
{

    enum Menu{
        adicao = 1, divisao = 2, multiplicacao = 3, subtracao = 4, sair = 5
    }
    private static void Main(string[] args)
    {
        bool continua = true;

        while (continua)

        {
            Console.WriteLine("Escolha a operacao");
            Console.WriteLine("1 - Adicao\n2 - divisao\n3 - multiplicacao\n4 - substracao\n5 - sair");
            Menu resposta = (Menu)int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case Menu.adicao:
                    Console.WriteLine("Adicao");
                    Console.Clear();
                    break;
                case Menu.divisao:
                    Console.WriteLine("Divisao");
                    Console.Clear();
                    break;
                case Menu.multiplicacao:
                    Console.WriteLine("Multiplicacao");
                    Console.Clear();
                    break;
                case Menu.subtracao:
                    Console.WriteLine("Subtracao");
                    Console.Clear();
                    break;
                case Menu.sair:
                    
                    continua = false;
                    break;
            }
        }
        
    }
        }