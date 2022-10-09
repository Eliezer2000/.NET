// See https://aka.ms/new-console-template for more information

class Veiculo{ //Classe base
    public int velMax;
    public int rodas;
    private bool ligado;
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        if(ligado){
            return"Sim";
        }else{
            return"Não";
        }
    }
}

class Carro:Veiculo{ //Classe Derivada
    public string nome;
    public string cor;

    public Carro(string nome, string cor){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula32
{
    static void Main(){
        Carro c1 = new Carro("fast","vermelho");
        Console.WriteLine($"Cor:......... {c1.cor}");
        Console.WriteLine($"Nome:........ {c1.nome}");
        Console.WriteLine($"Rodas:....... {c1.rodas}");
        Console.WriteLine($"Vel.Máxima:.. {c1.velMax}");
        Console.WriteLine($"Ligado:.......{c1.getLigado()}");
    }
}
