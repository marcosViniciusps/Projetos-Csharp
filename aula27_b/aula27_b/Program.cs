﻿using System;

namespace aula27_b {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual a hora atual? ");
            int horas = int.Parse(Console.ReadLine());

            if (horas < 12)
                Console.WriteLine("Bom dia!");
            else if (horas < 18)
                Console.WriteLine("Boa tarde!");
            else
                Console.WriteLine("Boa noite!");

        }
    }
}
