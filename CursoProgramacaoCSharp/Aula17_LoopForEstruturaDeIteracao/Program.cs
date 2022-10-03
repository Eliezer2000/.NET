// See https://aka.ms/new-console-template for more information
class Aula17
{
    static void Main(){

        int[] num = new int[10];

        for(int i = 0; i < num.Length; i ++){
            num[1] = i;
            
        }
        for(int i = 0; i < 10; i ++){
            Console.WriteLine($"Valor na posição {i}: {num[i]} ");
        }

    }
}
