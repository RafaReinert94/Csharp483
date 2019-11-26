using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.ConsoleApp.Tipos.TipoValor
{
    class Inteiros
    {
        public void Exercutar()
        {
        byte idade = 18;
        short numero = 222;
        //Console.WriteLine(idade);
        //Console.WriteLine(numero);

        //Console.WriteLine(byte.MinValue);
        //Console.WriteLine(Byte.MaxValue);

        //Console.WriteLine(short.MinValue);
        //Console.WriteLine(Int16.MaxValue);

        ////========= Sinal  U/S
        ////u sem sinal
        ////s com sinal
        //Console.WriteLine(ushort.MinValue);
        //Console.WriteLine(UInt16.MaxValue);

        //Console.WriteLine(int.MinValue);
        //Console.WriteLine(Int32.MaxValue);

        //Console.WriteLine(long.MinValue);
        //Console.WriteLine(Int64.MaxValue);


        ////Tabela ASCII 
        char letra = 'F';


        Console.WriteLine($"{ (int)letra} corresponde a letra {letra}");

            Console.ReadKey();

        }

    }
}
