using System;
using CalculadoraApp.CalculadoraOperations;

class Program
{
    static void Main()
    {
        CalculadoraService calculadoraService = new CalculadoraService();
        var numeros = calculadoraService.InserirNumCalculadora();
        calculadoraService.OperacoesCalculadora(numeros.Num1, numeros.Num2);
    }
}