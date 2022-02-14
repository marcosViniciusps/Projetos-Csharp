using System;

namespace aula22 {
    class Program {
        static void Main(string[] args) {

            string frase = Console.ReadLine();
            Console.WriteLine("Você digitou: "+ frase);

            string[] vet = Console.ReadLine().Split(' ');

            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);

        }
    }
}
