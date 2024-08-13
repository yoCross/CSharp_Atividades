using System;
class Program {
    static void Main(string[] args) {
        int a = 10, b = 20, aux;

        aux = a;
        a = b;
        b = aux;

        System.Console.WriteLine("O valor de A é: " + a + " e o valor de B é: " + b);
        Console.ReadLine();
    }
}