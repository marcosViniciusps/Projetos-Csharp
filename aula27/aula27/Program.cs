using System;

namespace aula27 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0) {
                Console.WriteLine($"O numero {n1} é par!", n1);
            }
            else {
                Console.WriteLine($"O numero {n1} é ímpar!", n1);
            }

        }
    }
}
