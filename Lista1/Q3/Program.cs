using System;
class Program{
    static void Main(string[] args){
        double salario, reajuste, salarionovo;
        Console.WriteLine("Escreva seu salario");
        double.TryParse(Console.ReadLine(), out salario);
        Console.WriteLine("Escreva a porcentagem de reajuste");
        double.TryParse(Console.ReadLine(), out reajuste);
        reajuste = (reajuste / 100) + 1;
        salarionovo = salario * reajuste;
        Console.WriteLine($"{salarionovo}");
    }
}