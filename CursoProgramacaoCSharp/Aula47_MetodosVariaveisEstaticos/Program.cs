// See https://aka.ms/new-console-template for more information

class Mat{
    public static double pi = 3.14;

    public static int dobro(int n){
        return n * 2;
    }
}

class Aula47
{
    static void Main(){
        double vpi = Mat.pi;
        int num = 10;

        Console.WriteLine(vpi);
        Console.WriteLine($"{Mat.dobro(num)}");
    }
}
