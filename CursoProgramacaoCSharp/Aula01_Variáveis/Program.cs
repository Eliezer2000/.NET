// See https://aka.ms/new-console-template for more information
class Aula01
{
    static void Main(){
        byte   n1     =  10;
        int    num    =  0;
        char   letra  =  'c';
        float  valor  =  5.3f;
        string nome   =  "Joel";

        var aux = nome;
        Console.WriteLine(aux);


        int num1, num2, res;
        num1 = 10;
        num2 = 2;
        res = num1 + num2;

        Console.WriteLine($"A soma de {num1} + {num2} é igual á {res}");
    }
}
