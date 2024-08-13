using System;
class Program{
    static void Main(string[] args){
        double a, l;
        Console.WriteLine("Escreva a altura e a largura de um retangulo");
        double.TryParse(Console.ReadLine(), out a);
        double.TryParse(Console.ReadLine(), out l);
        Console.WriteLine($"Area: {a * l}");
        System.Console.WriteLine($"Perimetro: {(a * 2) + (l * 2)}");
        Console.ReadKey();
    }
}