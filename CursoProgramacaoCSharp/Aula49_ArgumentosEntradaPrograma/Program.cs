// See https://aka.ms/new-console-template for more information


class Aula49
{
    static void Main(string[] args){

        int res = 0;

        if(args.Length > 0){
            Console.WriteLine($"Qtde de argumentos {args.Length}");
            for(int i=0; i < args.Length; i++){
                res += Convert.ToInt32(args[i]);
            }
            Console.WriteLine($"Soma: {res}");
        }else{
            Console.WriteLine("Não foram passados os argumentos");
        }
    }
}
