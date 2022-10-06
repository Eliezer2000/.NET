// See https://aka.ms/new-console-template for more information

public class Jogador{
    public int energia = 10;
    public bool vivo = true;
    public int idade;
}

class Aula26{
    static void Main(){
        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador();

        j1.energia = 50;
        j1.idade = 28;

        j2.energia = 100;
        j2.idade = 32;
        Console.WriteLine($"Energia do jogador 1: {j1.energia}\nA idade do jogador 1: {j1.idade}");
        Console.WriteLine("==========================");
        Console.WriteLine($"Energia do jogador 2: {j2.energia}\nA idade do jogador 2: {j2.idade}");
    }
}
