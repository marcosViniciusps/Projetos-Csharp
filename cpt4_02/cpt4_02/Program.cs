using System;

namespace cpt4_02 {
    class Program {
        static void Main(string[] args) {

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Funcionário 1");
            Console.Write("Digite o nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Digite o salário: ");
            f1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário 2");
            Console.Write("Digite o nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Digite o salário: ");
            f2.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Salário médio: {0}",(f1.salario+f2.salario)/2);

        }
    }
}
