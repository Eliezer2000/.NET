// See https://aka.ms/new-console-template for more information

class Aula19
{
    static void Main(){
        
        string senha = "123";
        string senhaUser;
        int tentativas = 0;
        

        do{
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhaUser = Console.ReadLine();
            tentativas ++;
        }
        while(senha != senhaUser);
        Console.Clear();
        Console.WriteLine($"Senha correta, tentativas: {tentativas}");
    }
}