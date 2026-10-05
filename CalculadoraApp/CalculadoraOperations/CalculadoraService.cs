using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using System.Xml.Serialization;
using CalculadoraApp.CalcEntites;

namespace CalculadoraApp.CalculadoraOperations
{
    public class CalculadoraService
    {

        public CalculadoraEntites InserirNumCalculadora()
        {

            Console.WriteLine("\n BEM VINDO A CALCULADORA MALUCA \n");

            Console.WriteLine("INSIRA O PRIMEIRO NÚMERO...: ");
            string primeiroNumero = Console.ReadLine() ?? "0";
            int num1 = int.Parse(primeiroNumero);


            Console.WriteLine("INSIRA O SEGUNDO NÚMERO...: ");
            string segundoNumero = Console.ReadLine() ?? "0";
            int num2 = int.Parse(segundoNumero);

            return new CalculadoraEntites { Num1 = num1, Num2 = num2 };

        }

        public void OperacoesCalculadora(int num1, int num2)
        {
            Console.WriteLine("ESCOLHA A OPERAÇÃO QUE DESEJA REALIZAR: \n");
            Console.WriteLine("1 - SOMA");
            Console.WriteLine("2 - SUBTRAÇÃO");
            Console.WriteLine("3 - MULTIPLICAÇÃO");
            Console.WriteLine("4 - DIVISÃO");
            Console.WriteLine("5 - SAIR");

            Console.WriteLine("DIGITE A OPÇÃO DESEJADA: ");
            var opcao = int.Parse(Console.ReadLine() ?? "0");


            switch (opcao)
            {
                case 1:
                    {
                        CalculadoraEntitiesOperations calc = new CalculadoraEntitiesOperations();
                        int resultadoSoma = calc.somar(num1, num2);
                        Console.WriteLine($"O resultado da soma é: {resultadoSoma}");
                        break;
                    }
                case 2:
                    {
                        CalculadoraEntitiesOperations calc = new CalculadoraEntitiesOperations();
                        int resultadoSubtracao = calc.subtrair(num1, num2);
                        Console.WriteLine($"O resultado da subtração é: {resultadoSubtracao}");
                        break;
                    }
                case 3:
                    {
                        CalculadoraEntitiesOperations calc = new CalculadoraEntitiesOperations();
                        int resultadoMultiplicacao = calc.multiplicar(num1, num2);
                        Console.WriteLine($"O resultado da multiplicação é: {resultadoMultiplicacao}");
                        break;
                    }
                case 4:
                    {
                        CalculadoraEntitiesOperations calc = new CalculadoraEntitiesOperations();
                        int resultadoDivisao = calc.dividir(num1, num2);
                        Console.WriteLine($"O resultado da divisão é: {resultadoDivisao}");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("SAINDO DA CALCULADORA...");
                        break;
                    }



            }
            Console.WriteLine("APERTE A TECLA PARA CONTINUAR...");
            Console.ReadKey();



            if (opcao != 5)
            {



                Console.Clear();
                OperacoesCalculadora(num1, num2);


            }








        }


    }
}