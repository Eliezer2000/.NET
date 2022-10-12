// See https://aka.ms/new-console-template for more information

class Base{

    public Base(){
        Console.WriteLine("Construtor da classe Base");
    }
    virtual public void info(){
        Console.WriteLine("base");
    }
}
class Derivada1:Base{

    public Derivada1(){
        Console.WriteLine("Construtor da classe Derivada1");
    }
    override public void info(){
        Console.WriteLine("Derivada1");
    }
}
class Derivada2:Derivada1{

    public Derivada2(){
        Console.WriteLine("Construtor da classe Derivada2");
    }
    override public void info(){
        Console.WriteLine("Derivada2");
    }
}



class Aula35{
    static void Main(){
        Base Ref;
        Derivada2 derivada2 = new Derivada2();
        Derivada1 derivada1 = new Derivada1();
        Ref = derivada2;
        Ref.info();
    }
}
