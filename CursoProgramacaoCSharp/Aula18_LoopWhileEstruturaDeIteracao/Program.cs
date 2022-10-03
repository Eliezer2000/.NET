// See https://aka.ms/new-console-template for more information
class Aula18
{
    static void Main(){
        int[] num = new int[10];

        int i = num.Length -1;
        while(i > 0){
            num[i] = 0;
            Console.WriteLine(num[1]);
            i--;
        }
        Console.WriteLine("Fim do loop");
    }
}
