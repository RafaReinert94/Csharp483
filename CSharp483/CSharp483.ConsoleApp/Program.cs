using CSharp483.ConsoleApp.Tipos.TipoValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inteiros inteiro = new Inteiros();
            //inteiro.Exercutar();

            Flutuante flutuante = new Flutuante();
            //flutuante.Executar();

            int numero = 10;
            int numeroCopia;
            numeroCopia = numero;

            Console.WriteLine($"Numero:{numero}");
            Console.WriteLine($"NumeroCopia:{numeroCopia}");


            Console.Read();

          
        }
    }
}
