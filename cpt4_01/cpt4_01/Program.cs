using System;

namespace cpt4_01 {
    class Program {
        static void Main(string[] args) {

            pessoa p1, p2;
            p1 = new pessoa();
            p2 = new pessoa();

            Console.Write("Digite o nome da primeira pessoa: ");
            p1.nome = Console.ReadLine();
            Console.Write("Digite a idade dela: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da segunda pessoa: ");
            p2.nome = Console.ReadLine();
            Console.Write("Digite a idade dela: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) {
                Console.Write("A pessoa mais velha é: {0}",p1.nome);
            }
            else {
                Console.Write("A pessoa mais velha é: {0}", p2.nome);

            }

        }
    }
}
