using System;

class Exercicio7 {
    static void Main() {
        int[] vetor = new int[10];

        for (int i = 0; i < 10; i++) {
            Console.Write($"Digite o valor da posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Vetor Original ---");
        Console.WriteLine(string.Join(" | ", vetor));

       
        for (int i = 0; i < 5; i++) {
            int temporario = vetor[i];
            vetor[i] = vetor[9 - i]; 
            vetor[9 - i] = temporario;
        }

        Console.WriteLine("\n--- Novo Vetor após as trocas ---");
        Console.WriteLine(string.Join(" | ", vetor));
    }
}