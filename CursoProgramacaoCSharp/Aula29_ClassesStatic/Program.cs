// See https://aka.ms/new-console-template for more information
static public class Jogador{
    static public int energia;
    static public bool vivo;
    static public int idade;
    static public string nome;
    static public void Iniciar(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }
  
    static public void Info(){
        Console.WriteLine($"Nome Jogador: {nome}");
        Console.WriteLine($"Energia Jogador: {energia}");
        Console.WriteLine($"Status Jogador: {vivo}\n");
    }
    
}

class Inimigo{
    static public bool alerta;
    public string nome;
    public Inimigo(string n){
        alerta = false;
        nome = n;
    }
    public void Info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("=============================");
    }
}

class Aula29{
    static void Main(){

        Jogador.Iniciar("Joel");
        Jogador.Info();
        
        Inimigo i1 = new Inimigo("Diguim");
        Inimigo i2 = new Inimigo("Papi");
        Inimigo i3 = new Inimigo("Cabelim");
        
        Inimigo.alerta = true;

        i1.Info();
        i2.Info();
        i3.Info();
    }
}
