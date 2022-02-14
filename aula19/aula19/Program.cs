using System;

namespace aula19 {
    class Program {
        static void Main(string[] args) {

            int a = 10;
            int b = 2;
            string c = "ABC";
            int d = 0;
            Console.WriteLine(a);

            a *= a;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            Console.WriteLine(c);

            c += "DEF";
            Console.WriteLine(c);

            d = a++;
            Console.WriteLine(a);
            Console.WriteLine(d);

            d = ++a;
            Console.WriteLine(a);
            Console.WriteLine(d);



        }
    }
}
