using System;
using System.Globalization;

namespace aula23_exercicio {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um porduto: ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira seu último nome, idade e altura na mesma linha: ");
            string[] vet = Console.ReadLine().Split();


            Console.WriteLine();
            Console.WriteLine("Informações: ");
            Console.WriteLine(nome);
            Console.WriteLine(n1);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
        }
    }
}
