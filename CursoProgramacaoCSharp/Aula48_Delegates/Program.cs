// See https://aka.ms/new-console-template for more information
delegate int Op(int n1, int n2);
class Mat{
    public static int soma(int n1, int n2){
        return n1 + n2;
    }

    public static int mult(int n1, int n2){
        return n1 * n2;
    }
}

class Aula48
{
    static void Main(){

        int res;
        Op d1 = new Op(Mat.soma);

        res = d1(10,50);
        Console.WriteLine($"Soma {res}");

        d1 = new Op(Mat.mult);

        res = d1(10,50);

        Console.WriteLine($"Multiplicação: {res}");
    }
}
