// See https://aka.ms/new-console-template for more information
class Aula10{
    static void Main(){
        
        int n1, n2, n3, n4, res;
        res = n1 = n2 = n3 = n4 = 0;
        string resultado = "Reprovado";

        Console.WriteLine("Digite sua nota 1: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        n4 = Convert.ToInt32(Console.ReadLine());

        res = n1 + n2 + n3 + n4; 

        if(res >= 60){
            resultado = "Aprovado";
        }
        
        Console.WriteLine($" Nota: {res}. Resultado: {resultado}");
    }
}
