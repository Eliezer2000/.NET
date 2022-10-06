// See https://aka.ms/new-console-template for more information
class Aula25
{
    static void Main(){
        soma(10, 5);
    }
    static void soma(params int[] n){
        int res = 0;
        if(n.Length < 1){
            Console.WriteLine("Não existem valores a serem somados");
        }else if(n.Length < 2){
            Console.WriteLine($"Valores insuficientes para soma {n[0]}");
        }else{
            for(int i = 0; i < n.Length; i++){
                res += n[i];
            }
            Console.WriteLine($"A soma dos valores é {res}");
        }
        
    }
}
