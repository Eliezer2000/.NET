// See https://aka.ms/new-console-template for more information

abstract class Veiculo{ //Classe base abstrata
    protected int velMaxima;
    protected int velAtual;
    protected bool ligado;
    public Veiculo(){
        ligado = false;
        velAtual = 0;
    }
    public void setLigado(bool ligado){
        this.ligado = ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }
    abstract public void aceleracao(int mult);
}
class Carro:Veiculo{
    public Carro(){
        velMaxima = 120;
    }
    override public void aceleracao(int mult){
        velAtual += 10*mult;
    }
}
class Aula37
{
    static void Main(){
        Carro carro = new Carro();
        carro.aceleracao(1);
        Console.WriteLine(carro.getVelAtual());
    }
}
