// See https://aka.ms/new-console-template for more information
class Aula09
{
    static void Main(){

        int   n1 = 10;
        float n2 = n1;
        Console.WriteLine(n2);

        float n3  = 10.5f;
        int   n4  = (int) n3; //type cast
        Console.WriteLine(n4);

        int vInt = 10;
        short vShort = (short) vInt;
        Console.WriteLine(vShort);
    }
}
