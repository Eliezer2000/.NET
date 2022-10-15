// See https://aka.ms/new-console-template for more information

struct Carro{
    public string modelo;
    public string cor;
    
    public void Info(){
        Console.WriteLine($"Modelo:...{this.modelo}");
        Console.WriteLine($"Cor:......{this.cor}");
        Console.WriteLine("==========================");
    }
}


class Aula43
{
    static void Main(){

        int[] numeros = new int[10];

        Carro[] carros = new Carro[4];

        carros[0].modelo = "HRV";
        carros[0].cor = "Prata";

        carros[1].modelo = "Golf";
        carros[1].cor = "Preto";

        carros[2].modelo = "Fusca";
        carros[2].cor = "Azul";

        carros[3].modelo = "Jeta";
        carros[3].cor = "Cinza";

        for(int i = 0; i < carros.Length; i++){
            carros[i].Info();
        }
    }
}
