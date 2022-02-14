using System;

namespace aula21 {
    class Program {
        static void Main(string[] args) {

            int n1 = 17 % 3;    // n1 recebe o resto da divisão inteira
            Console.WriteLine(n1);

            double n2 = 10 / 8;  // O valor sai truncado
            Console.WriteLine(n2);

            n2 = (double)10 / 8;    // Temos que adicionar um casting para evitar trucamento
            Console.WriteLine(n2);

            n2 = 10.0 / 8;  // Também podemos adicionar o .0 em algum dos valores para não ter truncamento
            Console.WriteLine(n2);

            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);


            Console.WriteLine(delta);


        }
    }
}
