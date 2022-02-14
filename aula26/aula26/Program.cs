using System;

namespace aula26 {
    class Program {
        static void Main(string[] args) {

            // Ordem de precedencia ! , && ,||

            bool c1 = 3 < 2 && 4 != 5;      // Falso
            bool c2 = 3 < 2 || 4 != 5;      // Verdadeiro
            bool c3 = !(3 < 2) && 4 != 5;   ////Verdadeiro

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine("------------------------");

            bool c4 = c1 || c2 && c3;   // Como o && tem precedencia sobre o || o resultado é verdadeiro
            Console.WriteLine(c4);

        }
    }
}
