using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp483.ConsoleApp.Tipos.TipoValor
{
    class Flutuante
    {

        public void Executar()
        {
            float numeroComVirgula = 10.01f;
            float numeroElevado = 10e6f;

            double numeroMaiorComVirgula = 1000.85;
            decimal salarioRafael = 1_000_000.5m;

            Console.WriteLine(numeroComVirgula);
            Console.WriteLine(numeroElevado);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(Single.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(Double.MinValue);

            //monetario
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(Decimal.MinValue);


            Console.Read();
        }
    }
}
