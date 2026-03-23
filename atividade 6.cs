using System;

class Exercicio6 {
    static void Main() {
        double[] salarios = new double[10];

        for (int i = 0; i < 10; i++) {
            Console.Write($"Digite o salário atual do funcionário {i+1}: R$ ");
            salarios[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n--- Salários com Reajuste de 5% ---");
        for (int i = 0; i < 10; i++) {
            salarios[i] = salarios[i] * 1.05; // Aplica o aumento de 5%
            Console.WriteLine($"Funcionário {i+1}: R$ {salarios[i]:F2}");
        }
    }
}