// See https://aka.ms/new-console-template for more information


/*
    2 - Ler um valor e escrever se é positivo ou negativo (considere o valor zero como positivo).
*/

class Div
{
    public static void txt()
    {
        Console.WriteLine("==============================");
    }
}
class Ex02
{
    static void Main()
    {
        string nome;
        int n;

        Console.WriteLine("Olá seja bem vindo!");
        Div.txt();
        Console.WriteLine("Digite o seu nome: ");
        nome = Console.ReadLine();
        Div.txt();
        Console.WriteLine("Digite um valor para saber se esse é positivo ou negativo: ");
        n = Convert.ToInt32(Console.ReadLine());
        Div.txt();
        if (n >= 0)
        {
            Console.WriteLine($"{nome} o numero que você digitou {n} é positivo!");
        }
        else
        {
            Console.WriteLine($"{nome} o numero que você digitou {n} é negativo!");
        }
    }
}

