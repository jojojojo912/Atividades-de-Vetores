using System;

class Exercicio5 {
    static void Main() {
        int[] vetor = new int[20];
        int qtdPares = 0, qtdImpares = 0, qtdMaiores50 = 0, qtdMenores7 = 0;

        for (int i = 0; i < 20; i++) {
            Console.Write($"Digite o valor {i+1} de 20: ");
            vetor[i] = int.Parse(Console.ReadLine());

            if (vetor[i] % 2 == 0) qtdPares++;
            else qtdImpares++;

            if (vetor[i] > 50) qtdMaiores50++;
            if (vetor[i] < 7) qtdMenores7++;
        }

        Console.WriteLine("Resultados");
        Console.WriteLine($"Quantidade de números pares: {qtdPares}");
        Console.WriteLine($"Quantidade de números ímpares: {qtdImpares}");
        Console.WriteLine($"Quantidade de números maiores do que 50: {qtdMaiores50}");
        Console.WriteLine($"Quantidade de números menores do que 7: {qtdMenores7}");
    }
}
