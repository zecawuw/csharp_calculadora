using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1, valor2, resultado;
            char operador;

            Operacao objOperador = new Operacao();

            Console.WriteLine("qual o primeiro valor?");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("qual o segundo valor?");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("qual o operador?");
            operador = Convert.ToChar(Console.ReadLine());

            resultado = objOperador.RealizarOperacao(valor1, valor2, operador);

            Console.WriteLine("O resultado da operação é: " + resultado);
            Console.ReadLine();
        }
    }
}
