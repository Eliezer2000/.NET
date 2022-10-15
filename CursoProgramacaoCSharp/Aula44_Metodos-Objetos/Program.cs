// See https://aka.ms/new-console-template for more information

class Galinha{

    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }
    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}
class Ovo{
    private int numOvo;
    private string minhaGalinha;
    public Ovo(int numOvo, string minhaGalinha){
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine($"Ovo criado:{this.numOvo} - {this.minhaGalinha}");
    }
}
class Aula44
{
    static void Main(){
        Galinha g1 = new Galinha("Galilda");
        Galinha g2 = new Galinha("Geralda");
        Galinha g3 = new Galinha("Marivalda");

        g1.botar();
        g2.botar();
        g3.botar();
        g3.botar();
    }
}
