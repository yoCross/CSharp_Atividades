using System;
class Program{
    static void Main(string[] args){
        int a;
        System.Console.WriteLine("Digite um numero");
        int.TryParse(Console.ReadLine(), out a);
        a = a - 1;
        System.Console.WriteLine($"O antecessor do seu numero e: {a}");
        Console.ReadKey();
    }
}