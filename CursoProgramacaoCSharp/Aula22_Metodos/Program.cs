// See https://aka.ms/new-console-template for more information
class Aula22
{
    static void Main(){
        int v1, v2,r;
        Console.WriteLine("Digite o primeiro número:");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        r = Soma(v1,v2);
        Console.WriteLine($"A soma de {v1} + {v2} é: {r}");
    }

    static int Soma(int n1, int n2){
        int res = n1 + n2;
        return res;
    }
}
