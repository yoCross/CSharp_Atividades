using System;
class Program {
    static void Main(string[] args) {

        double temp_celcius, temp_fahrenheit;

        Console.Write("Digite a temperatura em Fahrenheit: ");
        double.TryParse(Console.ReadLine(), out temp_fahrenheit);

        temp_celcius = (temp_fahrenheit - 32) / 1.8;

        System.Console.WriteLine("A temperatura em Celcius é de: " + temp_celcius);
        Console.ReadLine();
    }
}