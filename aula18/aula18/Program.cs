using System;
using System.Globalization; // Para usar o nvariantCulture

namespace aula18 {
    class Program {
        static void Main(string[] args) {

            string nome = "maria";
            int idade = 32;
            double saldo = 10.234567;

            Console.Write("Boa Noite!");
            Console.WriteLine("Bom dia!");

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("f4",CultureInfo.InvariantCulture));    // Para imprimir com . oa invés de ,

            Console.WriteLine("{0} tem {1} anos e tem saldo de {2} reais", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture)); // Placeholder
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo de {saldo:F2} reais");  // Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos " + "e tem saldo de " + saldo.ToString("F2") + " reais ");    // Concatenação
        }
    }
}
