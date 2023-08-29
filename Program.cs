global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
namespace Calculadora;

internal class Program
{

    enum Menu{
        adicao = 1, divisao = 2, multiplicacao = 3, subtracao = 4, sair = 5
    }

    private static void Main(string[] args)
    {
        bool continua = true;
        CalcOperations calculadora = new CalcOperations();
        double resultado;
        double numero1;
        double numero2;


        while (continua)

        {
            Console.WriteLine("Escolha a operacao");
            Console.WriteLine("1 - Adicao\n2 - divisao\n3 - multiplicacao\n4 - substracao\n5 - sair");
            Menu resposta = (Menu)int.Parse(Console.ReadLine());

            switch (resposta)
            {
                case Menu.adicao:
                    Console.WriteLine("Digite o primeiro número: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    numero2 = double.Parse(Console.ReadLine());
                    resultado = calculadora.adicao(numero1, numero2);
                    Console.WriteLine(resultado);
                   
                    break;
                case Menu.divisao:
                    Console.WriteLine("Digite o primeiro número: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    numero2 = double.Parse(Console.ReadLine());
                    resultado = calculadora.divisao(numero1, numero2);
                    Console.WriteLine(resultado);
                    
                    break;
                case Menu.multiplicacao:
                    Console.WriteLine("Digite o primeiro número: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    numero2 = double.Parse(Console.ReadLine());
                    resultado = calculadora.multiplicacao(numero1, numero2);
                    Console.WriteLine(resultado);
                    
                    break;
                case Menu.subtracao:
                    Console.WriteLine("Digite o primeiro número: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    numero2 = double.Parse(Console.ReadLine());
                    resultado = calculadora.subtracao(numero1, numero2);
                    Console.WriteLine(resultado);
                    
                    break;
                case Menu.sair:
                    continua = false;
                    
                    break;
            }
        }
        
    }
        }