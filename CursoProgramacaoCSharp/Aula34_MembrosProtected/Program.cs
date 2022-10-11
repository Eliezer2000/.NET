// See https://aka.ms/new-console-template for more information

class Veiculo{ //base
    public    int velAtual;
    private   int velMax;
    protected bool ligado;

    public Veiculo(int velMax){
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;
    }
    public bool getLigado(){
        return ligado;
    }
    public int getVelMax(){
        return velMax;   
    }
}

class Carro:Veiculo{ //Derivada de veiculo
    public string nome;
    public Carro(string nome, int vM):base(vM){
        this.nome = nome;
        ligado = true;
    }
    
}

class Aula34
{
    static void Main(){

        Carro carro = new Carro("Fast", 120);

        Console.WriteLine($"Nome: {carro.nome}");
        Console.WriteLine($"Velocidade máxima: {carro.getVelMax()}");
        Console.WriteLine($"ligado: {carro.getLigado()}");
    }
}
