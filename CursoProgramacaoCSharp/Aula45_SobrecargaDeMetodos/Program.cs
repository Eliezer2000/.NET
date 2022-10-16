// See https://aka.ms/new-console-template for more information

class Calc{
    public int soma(params int[]n){
        int s = 0;
        for(int i = 0; i < n.Length; i++){
            s += n[i];
        }
        return s;
    }
    public double soma(params double[]n){
        double s = 0;
        for(int i = 0; i < n.Length; i++){
            s += n[i];
        }
        return s;
    }

    
}
class Aula45
{
    static void Main(){

        

        Calc calc = new Calc();
        
        var res = calc.soma(10.3,2.6, 5.5, 9.3);

        Console.WriteLine(res);
    }
}
