using System;
using System.Globalization;

namespace aula42 {
    class Program {
        static void Main(string[] args) {

            int qte;

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do produto: {0}", p );
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.Write("Dados do produto: {0}", p);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.Write("Dados do produto: {0}", p);
            Console.WriteLine();


        }
    }
}
