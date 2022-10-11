// See https://aka.ms/new-console-template for more information

class Base{

    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
}
class Derivada1:Base{

    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
}
class Derivada2:Derivada1{

    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2");
    }
}



class Aula35{
    static void Main(){
        Derivada2 derivada2 = new Derivada2();
    }
}
