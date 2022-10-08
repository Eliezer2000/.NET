// See https://aka.ms/new-console-template for more information
public class Jogador{
    public int energia;
    public bool vivo;
    public int idade;
    public string nome;
    public Jogador(){
        energia = 100;
        vivo = true;
        nome = "Jogador";
    }
    public Jogador(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e){
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e, bool v){
        energia = e;
        vivo = v;
        nome = n;
    }
    public void Info(){
        Console.WriteLine($"Nome Jogador: {nome}");
        Console.WriteLine($"Energia Jogador: {energia}");
        Console.WriteLine($"Status Jogador: {vivo}\n");
    }
    
}

class Aula28{
    static void Main(){

        Jogador j1 = new Jogador();
        Jogador j2 = new Jogador("Joel");
        Jogador j3 = new Jogador("Paul",100);
        Jogador j4 = new Jogador("Michael",30,true);
        Jogador j5 = new Jogador("Bobson",0,false);

        j1.Info();
        j2.Info();
        j3.Info();
        j4.Info();
        j5.Info();
        
        
    }
}
