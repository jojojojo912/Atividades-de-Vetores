using System;

class Exercicio4 {
    static void Main() {
        int[] vetor1 = new int[10];
        int[] vetor2 = new int[10];
        int[] vetorResultante = new int[10];

        Console.WriteLine("--- Preenchendo o Vetor 1 ---");
        for (int i = 0; i < 10; i++) {
            Console.Write($"Vetor 1 - Posição {i}: ");
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Preenchendo o Vetor 2 ---");
        for (int i = 0; i < 10; i++) {
            Console.Write($"Vetor 2 - Posição {i}: ");
            vetor2[i] = int.Parse(Console.ReadLine());
            
           
            vetorResultante[i] = vetor1[i] + vetor2[i];
        }

        Console.WriteLine("\n--- Vetor Resultante (Soma) ---");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"Posição {i}: {vetorResultante[i]}");
        }
    }
}