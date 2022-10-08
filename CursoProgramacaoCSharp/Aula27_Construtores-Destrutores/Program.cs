// See https://aka.ms/new-console-template for more information

public class Jogador{
    public int energia;
    public bool vivo;
    public int idade;
    public string nome;
    public Jogador(string n, int id){
        energia = 100;
        vivo = true;
        nome = n;
        idade = id;
    }
    ~Jogador(){
        //Método destrutor
        Console.WriteLine("Jogador foi removido!");
    }
}

class Aula27{
    static void Main(){

        string nome1, nome2;
        int idade1, idade2;

        Console.WriteLine("Digite o primeiro nome: ");
        nome1 = Console.ReadLine();
        Console.WriteLine("Digite a idade: ");
        idade1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o Segundo nome: ");
        nome2 = Console.ReadLine();
        Console.WriteLine("Digite a idade: ");
        idade2 = Convert.ToInt32(Console.ReadLine());

        Jogador j1 = new Jogador(nome1,idade1);
        Jogador j2 = new Jogador(nome2,idade2);

        
        Console.WriteLine($"Nome do jogador 1: {j1.nome}.\nO jogador 1 tem a idade: {j1.idade} anos.\nE possui a energia: {j1.energia}");

        Console.WriteLine("==========================");

        Console.WriteLine($"Nome do jogador 2: {j2.nome}.\nO jogador 2 tem a idade: {j2.idade} anos.\nE possui a energia: {j2.energia}");
    }
}
