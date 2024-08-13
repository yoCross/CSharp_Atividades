using System;
class Program{
    static void Main(string[] args){
        double raio, volume;
        Console.WriteLine("escreva o raio de uma esfera");
        double.TryParse(Console.ReadLine(), out raio);

        raio = Math.Pow(raio, 3);
        volume = (4 * 3.14 * raio)/3;
        Console.WriteLine(volume.ToString("0.00"));
    }
}