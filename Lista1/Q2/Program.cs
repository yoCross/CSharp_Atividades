using System;
class Program{
    static void Main(string[] args){
        double peso, altura;
        Console.WriteLine("Digite seu peso");
        double.TryParse(Console.ReadLine(), out peso);
        Console.WriteLine("Digite seu altura");
        double.TryParse(Console.ReadLine(), out altura);
        System.Console.WriteLine($"Seu IMC e de: {peso / (altura * altura)}");
        Console.ReadKey();
    }
}