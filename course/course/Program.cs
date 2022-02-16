using System;

namespace course {
    class Program {
        static void Main(string[] args) {
            bool completo = false;
            char genero = 'F';
            char letra = '\u0043';
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;    // Numero máximo do int
            long n4 = 2147483648L; // Recomendação para explicitar que é um numero long
            float n5 = 4.5f;
            double n6 = 4.5;        // O float precisa do f no numero mas o double não
            string nome = "Maria Green";
            object obj1 = "Alex Brow";      // object é uma variável genérica
            object obj2 = 4.5;

            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.Write(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);

        }
    }
}
