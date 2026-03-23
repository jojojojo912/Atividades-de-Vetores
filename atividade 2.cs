using System;

class Exercicio2 {
    static void Main() {
        int[] vetor = new int[15];
        
        for (int i = 0; i < 15; i++) {
            Console.Write($"Digite o valor {i+1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("\nNúmeros positivos no vetor:");
        for (int i = 0; i < 15; i++) {
            if (vetor[i] > 0) {
                Console.WriteLine(vetor[i]);
            }
        }
    }
}