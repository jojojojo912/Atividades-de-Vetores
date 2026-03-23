using System;

class Exercicio3 {
    static void Main() {
        int[] vetor = new int[8];
        
        for (int i = 0; i < 8; i++) {
            Console.Write($"Digite o valor {i+1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }
        
        Console.Write("\nDigite um número para buscar no vetor: ");
        int busca = int.Parse(Console.ReadLine());
        bool encontrado = false;
        
        for (int i = 0; i < 8; i++) {
            if (vetor[i] == busca) {
                Console.WriteLine($"O elemento se encontra no vetor na posição: {i}");
                encontrado = true;
                break; // Interrompe a busca após encontrar a primeira ocorrência
            }
        }
        
        if (!encontrado) {
            Console.WriteLine("O número não se encontra no vetor");
        }
    }
}