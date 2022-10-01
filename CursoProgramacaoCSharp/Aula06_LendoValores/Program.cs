// See https://aka.ms/new-console-template for more information
class Aula06{
    static void Main(){
        int v1, v2, soma;
        string nome;

        Console.WriteLine("Olá, informe seu nome.\n");
        Console.WriteLine("Digite seu nome:\n");
        nome = Console.ReadLine();
        Console.WriteLine($"Seja bem vindo {nome}\n");

        Console.WriteLine("Digite o primeiro valor:\n ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor:\n ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine($"A soma de {v1} mais {v2} é igual a {soma}\n");
    }
}
