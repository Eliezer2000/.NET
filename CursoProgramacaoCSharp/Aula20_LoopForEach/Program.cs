// See https://aka.ms/new-console-template for more information
class Aula20{
    static void Main(){
        int[] num = new int[3] {22,11,77};
        
        for(int i = 0; i < num.Length; i ++){
            Console.WriteLine(num[i]);
        }


        int[] n = new int[3] {11,22,33};

        foreach(int x in n){
            Console.WriteLine(x);
        }
    }
}
