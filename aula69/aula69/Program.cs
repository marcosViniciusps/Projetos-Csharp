using System;
using System.Globalization;

namespace aula69 {
    class Program {
        static void Main(string[] args) {

            int i;
            int n = int.Parse(Console.ReadLine());
            double soma = 0.0;
            double avg = 0.0;

            double[] vect = new double[n];

            for( i = 0; i < n; i ++) {
                Console.Write("Digite um numero: ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (i = 0; i < n; i++) {
                soma += vect[i];
            }
            avg = soma / n;

            Console.WriteLine("Average Height = " + avg.ToString("F2",CultureInfo.InvariantCulture)); ;
        }
    }
}
