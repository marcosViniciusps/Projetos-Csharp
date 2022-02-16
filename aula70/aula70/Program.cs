using System;
using System.Globalization;

namespace aula70 {
    class Program {
        static void Main(string[] args) {

            int n;
            double soma = 0;
            double avg = 0.0;
            Console.Write("Digite a quantidade de produtos: ");
            n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < 3; i ++) {
                Console.Write("Digite o nome do Produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o preço do produto: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
                Console.WriteLine();
            }

            for(int i = 0; i < n; i++) {
                soma += vect[i].Price;
            }

            avg = soma / n;
            Console.WriteLine("Average Price = " + avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
