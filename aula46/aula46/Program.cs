using System;
using System.Globalization;

namespace aula46 {
    class Program {
        static void Main(string[] args) {

            double raio;
            double circ;
            double volume;

            Console.Write("Entre o valor do raio: ");
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            circ = Calculadora.Circunferencia(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2",CultureInfo.InvariantCulture));

            volume = Calculadora.Volume(raio);
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString(CultureInfo.InvariantCulture));

        }
    }
}
