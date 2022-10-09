// See https://aka.ms/new-console-template for more information
class Veiculo{ //Classe base
    public int velMax;
    private int rodas;
    private bool ligado;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }
    public void ligar(){
        ligado = true;
    }
    public void desligar(){
        ligado = false;
    }
    public string getLigado(){
        return (ligado ? "Sim":"Não");
    }
    public int getRodas(){
        return rodas;
    }
    public void setrodas(int rodas){
        if(rodas < 0){
            this.rodas = 0;
        }
        else if(rodas > 40){
            this.rodas = 40;
        }
        else{
            this.rodas = rodas;
        }

    }
}

class Carro:Veiculo{ //Classe Derivada
    public string nome;
    public string cor;

    public Carro(string nome, string cor):base(4){
        desligar();
        
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate:Carro{
    public int monicao;
    public CarroCombate():base("Carro de combate","Azul"){
        monicao = 100;
        setrodas(6);
    }
}
class Aula33
{
    static void Main(){
        Carro c1 = new Carro("fast","vermelho");
        CarroCombate c2 = new CarroCombate();

        c1.ligar();

        Console.WriteLine($"Cor:......... {c1.cor}");
        Console.WriteLine($"Nome:........ {c1.nome}");
        Console.WriteLine($"Rodas:....... {c1.getRodas()}");
        Console.WriteLine($"Vel.Máxima:.. {c1.velMax}");
        Console.WriteLine($"Ligado:.......{c1.getLigado()}");

        Console.WriteLine("===========================");

        Console.WriteLine($"Cor:......... {c2.cor}");
        Console.WriteLine($"Nome:........ {c2.nome}");
        Console.WriteLine($"Rodas:....... {c2.getRodas()}");
        Console.WriteLine($"Vel.Máxima:.. {c2.velMax}");
        Console.WriteLine($"Ligado:.......{c2.getLigado()}");
        Console.WriteLine($"Monição........{c2.monicao}");
    }
}
