// See https://aka.ms/new-console-template for more information

/*
    Ler um valor e escrever a mensagem 'É MAIOR QUE 10', se o valor lido for maior que 10, caso contrário 'NÃO É MAIOR QUE 10'
*/



class Ex01
{
    static void Main()
    {
        int n;
        Console.WriteLine("Olá, digite um número:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"O numero digitado foi {n} ");

        if (n > 10)
        {
            Console.WriteLine($"O valor digitado é maior que 10");
        }
        else if (n == 10)
        {
            Console.WriteLine("O valor digitado é igual a 10");
        }
        else
        {
            Console.WriteLine("O valor digitado é menor que 10");
        }
        Console.WriteLine("FIM .....");
    }
}




