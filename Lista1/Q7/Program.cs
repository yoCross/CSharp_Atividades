using System;
class Program {
    static void Main(string[] args) {
        
        int vBrancos, vNulos, vValidos, vTotais;
        double pBrancos, pNulos, pValidos;

        Console.Write("Digite o número de votos brancos: ");
        int.TryParse(Console.ReadLine(), out vBrancos);

        Console.Write("Digite o número de votos nulos: ");
        int.TryParse(Console.ReadLine(), out vNulos);

        Console.Write("Digite o número de votos válidos: ");
        int.TryParse(Console.ReadLine(), out vValidos);

        vTotais = vBrancos + vNulos + vValidos;

        pBrancos = (vBrancos * 100) / vTotais;
        pNulos = (vNulos * 100) / vTotais;
        pValidos = (vValidos * 100) / vTotais;

        System.Console.WriteLine("A porcentagem de votos válidos é de: " + pValidos +"% a porcentagem de votos brancos é de: " + pBrancos + "% a porcentagem de votos nulos é de: " + pNulos + "% e a quantidade total de votos é de: " + vTotais);
        Console.ReadLine();
    }
}