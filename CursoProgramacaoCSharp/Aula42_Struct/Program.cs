// See https://aka.ms/new-console-template for more information

struct Carro{
    public string marca;
    public string modelo;
    public string cor;
    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }
    public void Info(){
        Console.WriteLine($"Marca:....{this.marca}");
        Console.WriteLine($"Modelo:...{this.modelo}");
        Console.WriteLine($"Cor:......{this.cor}");
        Console.WriteLine("==========================");
    }
}


class Aula42
{
    static void Main(){
        Carro c1;
        c1.marca = "Vw";
        c1.modelo = "Golf";
        c1.cor = "Branco";

        Carro c2 = new Carro("Honda","MRV","Prata");

        c1.Info();
        c2.Info();
    }
}
