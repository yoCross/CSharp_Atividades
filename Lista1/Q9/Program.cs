using System;
class Program {
    static void Main(string[] args) {
        double cFabrica, pDistribuidor = 1.28, pImpostos = 1.45, vFinal;

        System.Console.Write("Digite o custo de fábrica do carro: ");
        double.TryParse(Console.ReadLine(), out cFabrica);

        vFinal = cFabrica * pDistribuidor * pImpostos;

        System.Console.WriteLine("O valor final do carro é de: " + vFinal);
        Console.ReadLine();
    }
}