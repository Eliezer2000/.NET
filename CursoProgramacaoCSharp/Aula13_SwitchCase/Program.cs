// See https://aka.ms/new-console-template for more information
class Aula13
{
    static void Main(){

        int tempo = 0;
        char escolha;

        Console.WriteLine("Rio de Janeiro/RJ a São Paulo/SP");
        Console.WriteLine("Escolha o transporte: [A] Avião [C] Carro  [O] Onibus");
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':
                tempo = 50;
                break;
            case 'c':
            case 'C':
                tempo = 480;
                break;
            case 'o':
            case 'O':
                tempo = 660;
                break;
            default:
                tempo = -1;
                break;
        }
        if(tempo < 0){
            Console.WriteLine("Transporte indisponível");
        }else{
            Console.WriteLine($"Para o transporte escolhido o tempo é: {tempo} minutos.");
        }
    }
}
