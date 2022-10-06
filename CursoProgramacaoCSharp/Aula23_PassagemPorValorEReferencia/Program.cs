// See https://aka.ms/new-console-template for more information
class Aula23{
    static void Main(){
        int num = 50;
        dobrar2(num);
        Console.WriteLine(num);
    }
    static void dobrar1(ref int valor){
        valor *= 2;
    }

    static void dobrar2( int valor){
        valor *= 2;
    }
}
