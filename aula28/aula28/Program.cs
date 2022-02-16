using System;

namespace aula28 {
    class Program {
        static void Main(string[] args) {

            double preco = double.Parse(Console.ReadLine());
            double desconto = 0.0;  // É necessário declarar e inicializar a variável para que ela exista em todo o programa
            //double desconto;      Se não for inicializada ela não poderá ser impressa

            if (preco >= 100)
                // double esconto = preco * 0.1; 
                //  A variável não pode ser iniciada dentro do if se não ela só existirá dentro desse escopo
                desconto = preco * 0.1;

            Console.WriteLine("O desconto é de: ");
            Console.WriteLine(desconto);

        }
    }
}
