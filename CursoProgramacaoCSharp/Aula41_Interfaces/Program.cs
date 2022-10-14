// See https://aka.ms/new-console-template for more information

public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo, Combate
{
    public bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao =qtde;
    }
    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }
    public void disparar(){
        
    }
    public void info(){

    }
}
class Aula41
{
    static void Main(){
        Carro c1 = new Carro();
    }
}
