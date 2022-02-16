using System;
using System.Globalization;

namespace aula48_exercicio {
    class Program {
        static void Main(string[] args) {

            double cotacao;
            int quantidade;
            double valor;

            Console.WriteLine("Qual é a cotação do dólar?");
            cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar?");
            quantidade = int.Parse(Console.ReadLine());

            valor = ConversorDeMoeda.convert(cotacao, quantidade);
            Console.WriteLine("Valor total pago em reail: " + valor.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
