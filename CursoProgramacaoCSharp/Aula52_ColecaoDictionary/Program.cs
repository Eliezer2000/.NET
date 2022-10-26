// See https://aka.ms/new-console-template for more information

class Aula52
{
    static void Main()
    {
        Dictionary<int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        //veiculos.Clear(); Limpar Dicitionary

        veiculos.Remove(20); //Remover valor

        Console.WriteLine($"Tamanho do Dictionary: {veiculos.Count}");

        int chave = 20;
        if (veiculos.ContainsKey(chave))
        {
            Console.WriteLine($"A chave {chave} está na coleção");
        }
        else
        {
            Console.WriteLine($"A chave {chave} não esta na coleção");
        }

        veiculos[15] = "Bicicleta";


        string valor = "Bicicleta";
        if (veiculos.ContainsValue(valor))
        {
            Console.WriteLine($"O valor {valor} está na coleção");
        }
        else
        {
            Console.WriteLine($"O valor {valor} não esta na coleção");
        }


        Dictionary<int, string>.ValueCollection valores = veiculos.Values;

        foreach (string v in valores)
        {
            Console.WriteLine(v);
        }
    }
}
