using System;

namespace aula35 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantos numeros inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());
            int soma = 0;

            for(int i = 1; i <= N; i++) {
                Console.Write("Valor #{0}: ",i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
            Console.WriteLine();
            Console.WriteLine("A soma total é: {0}",soma);

        }
    }
}
