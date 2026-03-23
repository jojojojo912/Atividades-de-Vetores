using System;

class Exercicio1 {
    static void Main() {
        int[] vetor = new int[10];
        int soma = 0;
        
        for (int i = 0; i < 10; i++) {
            Console.Write($"Digite o valor {i+1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
            soma += vetor[i];
        }
        
        Console.WriteLine($"Somatório do vetor: {soma}");
    }
}