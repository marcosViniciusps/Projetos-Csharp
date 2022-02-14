using System;

namespace aula20 {
    class Program {
        static void Main(string[] args) {

            double a;
            float b;
            int c;
            int d = 2;

            a = 5.1;
            b = (float)a;   // É necessário converter o valor para float
            c = (int)a;   // É necessário converter o valor para int e mesmo assim ele sai truncado
            Console.WriteLine(b);
            Console.WriteLine(c);

            double resultado = (double)c / d; // É necessário converter um dos valores para double para não perder informação
            Console.WriteLine(resultado);
        }
    }
}
